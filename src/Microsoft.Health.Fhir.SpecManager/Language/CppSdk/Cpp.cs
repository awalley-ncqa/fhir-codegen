// <copyright file="CSharp2.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Health.Fhir.SpecManager.Manager;
using Microsoft.Health.Fhir.SpecManager.Models;

namespace Microsoft.Health.Fhir.SpecManager.Language
{
    /// <summary>A basic C# language - useful for testing, simple projects, and prototypes.</summary>
    public sealed class Cpp : ILanguage
    {
        /// <summary>FHIR information we are exporting.</summary>
        private FhirVersionInfo _info;

        /// <summary>Options for controlling the export.</summary>
        private ExporterOptions _options;

        /// <summary>True to export enums.</summary>
        private bool _exportEnums;

        /// <summary>The base namespace to use for all exported classes.</summary>
        private string _namespace;

        /// <summary>The namespace models.</summary>
        private string _namespaceModels;

        /// <summary>The serialization namespace.</summary>
        private string _namespaceSerialization;

        /// <summary>True to include, false to exclude the summaries.</summary>
        private bool _includeSummaries = true;

        /// <summary>The access modifier.</summary>
        private string _accessModifier = "public";

        /// <summary>Pathname of the model directory.</summary>
        private string _directoryModels;

        /// <summary>Pathname of the value set directory.</summary>
        private string _directoryValueSets;

        /// <summary>Pathname of the serialization directory.</summary>
        private string _directorySerialization;

        /// <summary>List of types of the exported resource names and types.</summary>
        private Dictionary<string, string> _exportedResourceNamesAndTypes = new Dictionary<string, string>();

        /// <summary>The exported codes.</summary>
        private HashSet<string> _exportedCodes = new HashSet<string>();

        /// <summary>The currently in-use text writer.</summary>
        private ExportStreamWriter _writer;

        /// <summary>Name of the language.</summary>
        private const string _languageName = "Cpp";

        /// <summary>The single file export extension - requires directory export.</summary>
        private const string _singleFileExportExtension = null;

        /// <summary>Dictionary mapping FHIR primitive types to language equivalents.</summary>
        private static readonly Dictionary<string, string> _primitiveTypeMap = new Dictionary<string, string>()
        {
            { "base", "Object" }, // TODO(agw): not sure what to do with this...we shouldn't ever have this
            { "base64Binary", "NullableString8" },
            { "bool", "NullableBoolean" },
            { "bool?", "NullableBoolean" },
            { "boolean", "NullableBoolean" },
            { "canonical", "NullableString8" },
            { "code", "NullableString8" },
            { "date", "ISO8601_Time" },
            { "dateTime", "ISO8601_Time" },           // Cannot use "DateTime" because of Partial Dates... may want to consider defining a new type, but not today
            { "decimal", "NullableString8" },
            { "id", "NullableString8" },
            { "instant", "ISO8601_Time" },
            { "int", "NullableInt32" },
            { "int?", "NullableInt32" },
            { "integer", "NullableInt32" },
            { "integer64", "NullableInt64" },
            { "markdown", "NullableString8" },
            { "oid", "NullableString8" },
            { "positiveInt", "NullableInt32" },
            { "NullableString8", "NullableString8" },
            { "NullableString8?", "NullableString8" },
            { "time", "ISO8601_Time" },
            { "unsignedInt", "NullableInt32" },
            { "uri", "NullableString8" },
            { "url", "NullableString8" },
            { "uuid", "NullableString8" },
            { "xhtml", "NullableString8" },
        };

        /// <summary>Gets the reserved words.</summary>
        /// <value>The reserved words.</value>
        private static readonly HashSet<string> _reservedWords = new HashSet<string>()
        {
        "alignas",
        "alignof",
        "and",
        "and_eq",
        "asm",
        "atomic_cancel",
        "atomic_commit",
        "atomic_noexcept",
        "auto",
        "bitand",
        "bitor",
        "bool",
        "break",
        "case",
        "catch",
        "char",
        "char8_t",
        "char16_t",
        "char32_t",
        "class",
        "compl",
        "concept",
        "const",
        "consteval",
        "constexpr",
        "constinit",
        "const_cast",
        "continue",
        "co_await",
        "co_return",
        "co_yield",
        "decltype",
        "default",
        "delete",
        "do",
        "double",
        "dynamic_cast",
        "else",
        "enum",
        "explicit",
        "export",
        "extern",
        "false",
        "float",
        "for",
        "friend",
        "goto",
        "if",
        "inline",
        "int",
        "long",
        "mutable",
        "namespace",
        "new",
        "noexcept",
        "not",
        "not_eq",
        "nullptr",
        "operator",
        "or",
        "or_eq",
        "private",
        "protected",
        "public",
        "reflexpr",
        "register",
        "reinterpret_cast",
        "requires",
        "return",
        "short",
        "signed",
        "sizeof",
        "static",
        "static_assert",
        "static_cast",
        "struct",
        "switch",
        "synchronized",
        "template",
        "this",
        "thread_local",
        "throw",
        "true",
        "try",
        "typedef",
        "typeid",
        "typename",
        "union",
        "unsigned",
        "using",
        "virtual",
        "void",
        "volatile",
        "wchar_t",
        "while",
        "xor",
        "xor_eq",
        };

        /// <summary>Gets the name of the language.</summary>
        /// <value>The name of the language.</value>
        string ILanguage.LanguageName => _languageName;

        /// <summary>
        /// Gets the single file extension for this language - null or empty indicates a multi-file
        /// export (exporter should copy the contents of the directory).
        /// </summary>
        string ILanguage.SingleFileExportExtension => _singleFileExportExtension;

        /// <summary>Gets the FHIR primitive type map.</summary>
        /// <value>The FHIR primitive type map.</value>
        Dictionary<string, string> ILanguage.FhirPrimitiveTypeMap => _primitiveTypeMap;

        /// <summary>Gets the reserved words.</summary>
        /// <value>The reserved words.</value>
        HashSet<string> ILanguage.ReservedWords => _reservedWords;

        /// <summary>
        /// Gets a list of FHIR class types that the language WILL export, regardless of user choices.
        /// Used to provide information to users.
        /// </summary>
        List<ExporterOptions.FhirExportClassType> ILanguage.RequiredExportClassTypes => new List<ExporterOptions.FhirExportClassType>()
        {
            ExporterOptions.FhirExportClassType.ComplexType,
            ExporterOptions.FhirExportClassType.Resource,
        };

        /// <summary>
        /// Gets a list of FHIR class types that the language CAN export, depending on user choices.
        /// </summary>
        List<ExporterOptions.FhirExportClassType> ILanguage.OptionalExportClassTypes => new List<ExporterOptions.FhirExportClassType>()
        {
            ExporterOptions.FhirExportClassType.Enum,
        };

        /// <summary>Gets language-specific options and their descriptions.</summary>
        Dictionary<string, string> ILanguage.LanguageOptions => new Dictionary<string, string>()
        {
            { "namespace", "Base namespace for C# classes (default: fhir_r{VersionNumber})." },
            { "access-modifier", "Access modifier for exported elements (public|internal|private)." },
        };

        /// <summary>Export the passed FHIR version into the specified directory.</summary>
        /// <param name="info">           The information.</param>
        /// <param name="serverInfo">     Information describing the server.</param>
        /// <param name="options">        Options for controlling the operation.</param>
        /// <param name="exportDirectory">Directory to write files.</param>
        void ILanguage.Export(
            FhirVersionInfo info,
            FhirCapabiltyStatement serverInfo,
            ExporterOptions options,
            string exportDirectory)
        {
            // set internal vars so we don't pass them to every function
            // this is ugly, but the interface patterns get bad quickly because we need the type map to copy the FHIR info
            _info = info;
            _options = options;

            if (options.OptionalClassTypesToExport.Contains(ExporterOptions.FhirExportClassType.Enum))
            {
                _exportEnums = true;
            }
            else
            {
                _exportEnums = false;
            }

            _namespace = options.GetParam("namespace", $"fhir_{info.FhirSequence}");
            _namespaceModels = _namespace;

            _includeSummaries = options.GetParam("include-summaries", true);
            _accessModifier = options.GetParam("access-modifier", "public");

            _exportedResourceNamesAndTypes = new Dictionary<string, string>();
            _exportedCodes = new HashSet<string>();

            _directoryModels = Path.Combine(exportDirectory, "Models");
            if (!Directory.Exists(_directoryModels))
            {
                Directory.CreateDirectory(_directoryModels);
            }

            _directoryValueSets = Path.Combine(exportDirectory, "ValueSets");
            if (_exportEnums)
            {
                if (!Directory.Exists(_directoryValueSets))
                {
                    Directory.CreateDirectory(_directoryValueSets);
                }
            }

            _directorySerialization = Path.Combine(exportDirectory, "Serialization");
            if (!Directory.Exists(_directorySerialization))
            {
                Directory.CreateDirectory(_directorySerialization);
            }

            WriteComplexes(_info.ComplexTypes.Values, false);
            WriteComplexes(_info.Resources.Values, true);

            /* TODO(agw): Do I even need this?
            if (_exportEnums) 
            {
                WriteValueSets(_info.ValueSetsByUrl.Values);
            }
            */

            // TODO(agw): write metadata file...

            //WriteJsonSerializationHelpers();
            //WriteXmlSerializationHelpers();
        }


        /// <summary>Writes the complexes.</summary>
        /// <param name="complexes"> The complexes.</param>
        /// <param name="isResource">(Optional) True if is resource, false if not.</param>
        private void WriteComplexes(
            IEnumerable<FhirComplex> complexes,
            bool isResource = false)
        {
            Dictionary<string, FhirComplex> fhirComplexFromName = new Dictionary<string, FhirComplex>();
            foreach (FhirComplex complex in complexes)
            {
                fhirComplexFromName.Add(complex.Name, complex);
            }

            foreach (FhirComplex complex in complexes)
            {
                // create a filename for writing
                string filename = Path.Combine(_directoryModels, $"{complex.NameCapitalized}.cc");

                using (FileStream stream = new FileStream(filename, FileMode.Create))
                using (ExportStreamWriter writer = new ExportStreamWriter(stream))
                {
                    _writer = writer;

                    WriteHeader(false, true, false);

                    // open namespace
                    _writer.WriteLineIndented($"namespace {_namespaceModels}");
                    _writer.OpenScope();

                    WriteComplex(complex, isResource, fhirComplexFromName);

                    // close namespace
                    _writer.CloseScope("};");

                    WriteFooter();
                }
            }
        }

        /// <summary>Writes a complex.</summary>
        /// <param name="complex">   The complex.</param>
        /// <param name="isResource">True if is resource, false if not.</param>
        private void WriteComplex(
            FhirComplex complex,
            bool isResource,
            Dictionary<string, FhirComplex> fhirComplexFromName)
        {

            // NOTE(agw): We want to just directly write the complex elements in the struct
            // check for nested components
            if (complex.Components != null)
            {
                foreach (FhirComplex component in complex.Components.Values)
                {
                    WriteComplex(component, false, fhirComplexFromName);
                }
            }

            if (!string.IsNullOrEmpty(complex.Comment))
            {
                WriteIndentedComment(complex.Comment);
            }

            string nameForExport;
            bool hasBaseClass;
            string baseClassName;

            if (string.IsNullOrEmpty(complex.BaseTypeName) ||
                complex.Name.Equals("Element", StringComparison.Ordinal))
            {
                nameForExport = complex.NameForExport(FhirTypeBase.NamingConvention.PascalCase);
                hasBaseClass = false;
                baseClassName = string.Empty;

                _writer.WriteLineIndented($"struct {nameForExport} {{");
            }
            else if (complex.Name.Equals(complex.BaseTypeName, StringComparison.Ordinal))
            {
                nameForExport = complex.NameForExport(FhirTypeBase.NamingConvention.PascalCase, true);
                hasBaseClass = false;
                baseClassName = string.Empty;

                _writer.WriteLineIndented( $"struct {nameForExport} {{");
            }
            else if ((complex.Components != null) && complex.Components.ContainsKey(complex.Path))
            {
                nameForExport = complex.NameForExport(FhirTypeBase.NamingConvention.PascalCase, true);
                hasBaseClass = true;
                baseClassName = complex.TypeForExport(FhirTypeBase.NamingConvention.PascalCase, _primitiveTypeMap, false);

                // TODO(agw): here we want to just paste all of the subfields first (no direct inheritence)
                _writer.WriteLineIndented( $"struct {nameForExport} {{");
            }
            else
            {
                nameForExport = complex.NameForExport(FhirTypeBase.NamingConvention.PascalCase, true);
                hasBaseClass = true;
                baseClassName = complex.TypeForExport(FhirTypeBase.NamingConvention.PascalCase, _primitiveTypeMap);

                _writer.WriteLineIndented($"struct {nameForExport} {{");
            }

            _writer.IncreaseIndent();

            if (isResource)
            {
                _writer.WriteLineIndented($"ResourceType resourceType;");
            }


            WriteElements(complex, out List<FhirElement> elementsWithCodes);

            // close interface (type)
            _writer.CloseScope("};");

            /* TODO(agw): don't think I need to do this
            if (_exportEnums)
            {
                foreach (FhirElement element in elementsWithCodes)
                {
                    WriteCode(element);
                }
            }
            */
        }

        /// <summary>Writes the elements.</summary>
        /// <param name="complex">          The complex.</param>
        /// <param name="elementsWithCodes">[out] The elements with codes.</param>
        private void WriteElements(
            FhirComplex complex,
            out List<FhirElement> elementsWithCodes)
        {
            elementsWithCodes = new List<FhirElement>();

            foreach (FhirElement element in complex.Elements.Values)
            {
                /* TODO(agw): For CPP we _don't_ want inheritence
                if (element.IsInherited)
                {
                    continue;
                }
                */

                WriteElement(complex, element);

                if ((element.Codes != null) && (element.Codes.Count > 0))
                {
                    elementsWithCodes.Add(element);
                }
            }
        }

        /// <summary>Writes an element.</summary>
        /// <param name="complex">The complex.</param>
        /// <param name="element">The element.</param>
        private void WriteElement(
            FhirComplex complex,
            FhirElement element)
        {
            Dictionary<string, string> values = element.NamesAndTypesForExport(
                FhirTypeBase.NamingConvention.CamelCase,
                FhirTypeBase.NamingConvention.PascalCase,
                false,
                string.Empty,
                complex.Components.ContainsKey(element.Path));

            bool isMultiTyped = values.Count > 1;

            foreach (KeyValuePair<string, string> kvp in values)
            {
                string elementName;
                if ((kvp.Key == complex.Name) && (!element.IsInherited))
                {
                    elementName = $"{kvp.Key}Field";
                }
                else
                {
                    elementName = kvp.Key;
                }

                if (!string.IsNullOrEmpty(element.Comment))
                {
                    WriteIndentedComment(element.Comment);
                }

                string ptr = element.IsSimple ? "" : "*";
                string elementType = element.IsArray
                    ? $"{kvp.Value}*{ptr}"
                    : $"{kvp.Value}{ptr}";


                if(element.IsArray)
                {
                    _writer.WriteLineIndented($"size_t _{elementName}_count;");
                }

                _writer.WriteLineIndented($"{elementType} _{elementName};");
            }
        }

        /// <summary>Writes a header.</summary>
        /// <param name="isValueSet">     True if this is the header for a ValueSet.</param>
        /// <param name="isModel">        True if this is the header for a Model.</param>
        /// <param name="isSerialization">True if is serialization, false if not.</param>
        private void WriteHeader(bool isValueSet, bool isModel, bool isSerialization)
        {
            _writer.WriteLineIndented("// <auto-generated />");
            _writer.WriteLineIndented($"// Built from: {_info.PackageName} version: {_info.VersionString}");

            if ((_options.ExportList != null) && _options.ExportList.Any())
            {
                string restrictions = string.Join("|", _options.ExportList);
                _writer.WriteLineIndented($"  // Restricted to: {restrictions}");
            }

            if ((_options.LanguageOptions != null) && (_options.LanguageOptions.Count > 0))
            {
                foreach (KeyValuePair<string, string> kvp in _options.LanguageOptions)
                {
                    _writer.WriteLineIndented($"  // Option: \"{kvp.Key}\" = \"{kvp.Value}\"");
                }
            }

            _writer.WriteLine();

            /*
            if (!_includeSummaries)
            {
                _writer.WriteLineIndented("#pragma warning disable 1591");
                _writer.WriteLine();
            }
            */
        }

        /// <summary>Writes a footer.</summary>
        private void WriteFooter()
        {
            if (!_includeSummaries)
            {
                _writer.WriteLine();
                _writer.WriteLineIndented("#pragma warning restore 1591");
                _writer.WriteLine();
            }
        }

        /// <summary>Writes an indented comment.</summary>
        /// <param name="value">    The value.</param>
        /// <param name="isSummary">(Optional) True if is summary, false if not.</param>
        private void WriteIndentedComment(string value, bool isSummary = true)
        {
            string comment;
            string[] lines;

            if (isSummary)
            {
                if (!_includeSummaries)
                {
                    return;
                }

                _writer.WriteLineIndented("/// <summary>");

                comment = value
                    .Replace('\r', '\n')
                    .Replace("\r\n", "\n", StringComparison.Ordinal)
                    .Replace("\n\n", "\n", StringComparison.Ordinal)
                    .Replace("&", "&amp;", StringComparison.Ordinal)
                    .Replace("<", "&lt;", StringComparison.Ordinal)
                    .Replace(">", "&gt;", StringComparison.Ordinal);

                lines = comment.Split('\n');
                foreach (string line in lines)
                {
                    _writer.WriteIndented("/// ");
                    _writer.WriteLine(line);
                }

                _writer.WriteLineIndented("/// </summary>");

                return;
            }

            comment = value
                .Replace('\r', '\n')
                .Replace("\r\n", "\n", StringComparison.Ordinal)
                .Replace("\n\n", "\n", StringComparison.Ordinal);

            lines = comment.Split('\n');
            foreach (string line in lines)
            {
                _writer.WriteIndented("// ");
                _writer.WriteLine(line);
            }
        }
    }
}
