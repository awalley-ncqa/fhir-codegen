﻿// <copyright file="FhirImplementationGuide.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

namespace Microsoft.Health.Fhir.CodeGenCommon.Models;

/// <summary>
/// Class representing normalized ImplementationGuide resources.
/// </summary>
public class FhirImplementationGuide : FhirModelBase, ICloneable
{
    public record struct IgDependsOn(
        string IgUri,
        string PackageId,
        string Version);

    private Dictionary<string, IgDependsOn> _dependsOn = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="FhirImplementationGuide"/> class.
    /// </summary>
    /// <param name="id">               The identifier.</param>
    /// <param name="name">             The name.</param>
    /// <param name="url">              URL of the resource.</param>
    /// <param name="version">          Version of this definition.</param>
    /// <param name="publicationStatus">The publication status.</param>
    /// <param name="standardStatus">   The standard status.</param>
    /// <param name="fmmLevel">         The fmm level.</param>
    /// <param name="isExperimental">   A value indicating whether this object is experimental.</param>
    /// <param name="shortDescription"> Information describing the short.</param>
    /// <param name="purpose">          The purpose.</param>
    /// <param name="comment">          The comment.</param>
    /// <param name="packageId">        Package ID that contains this IG.</param>
    /// <param name="fhirVersion">      FHIR versions this IG applies to.</param>
    /// <param name="dependsOn">        Package dependencies for this IG.</param>
    /// <param name="validationRegEx">  Validation regex pattern for this definition.</param>
    /// <param name="narrative">        Narrative content for this resource.</param>
    /// <param name="narrativeStatus">  Narrative status for the narrative of this resource.</param>
    public FhirImplementationGuide(
        string id,
        string name,
        Uri url,
        string version,
        string publicationStatus,
        string standardStatus,
        int? fmmLevel,
        bool isExperimental,
        string shortDescription,
        string purpose,
        string comment,
        string packageId,
        IEnumerable<string> fhirVersion,
        Dictionary<string, IgDependsOn> dependsOn,
        string validationRegEx,
        string narrative,
        string narrativeStatus)
        : base(
            FhirArtifactClassEnum.ImplementationGuide,
            id,
            name,
            string.Empty,
            string.Empty,
            string.Empty,
            version,
            url,
            publicationStatus,
            standardStatus,
            fmmLevel,
            isExperimental,
            shortDescription,
            purpose,
            comment,
            validationRegEx,
            narrative,
            narrativeStatus,
            fhirVersion.Any() ? fhirVersion.First() : string.Empty)
    {
        PackageId = packageId;
        FhirVersions = fhirVersion;
        _dependsOn = dependsOn;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FhirImplementationGuide"/> class.
    /// </summary>
    /// <param name="source">Source for the.</param>
    public FhirImplementationGuide(FhirImplementationGuide source)
        : this(
            source.Id,
            source.Name,
            source.URL,
            source.Version,
            source.PublicationStatus,
            source.StandardStatus,
            source.FhirMaturityLevel,
            source.IsExperimental,
            source.ShortDescription,
            source.Purpose,
            source.Comment,
            source.PackageId,
            source.FhirVersions.Select(s => s),
            new(),
            source.ValidationRegEx,
            source.NarrativeText,
            source.NarrativeStatus)
    {
        if (source._dependsOn?.Any() ?? false)
        {
            foreach (KeyValuePair<string, IgDependsOn> kvp in source._dependsOn)
            {
                _dependsOn.Add(kvp.Key, new(kvp.Value.IgUri, kvp.Value.PackageId, kvp.Value.Version));
            }
        }
    }


    public string PackageId { get; }

    public IEnumerable<string> FhirVersions { get; }

    public Dictionary<string, IgDependsOn> DependsOn => _dependsOn;

    /// <summary>Makes a deep copy of this object.</summary>
    /// <returns>A copy of this object.</returns>
    public object Clone()
    {
        return new FhirImplementationGuide(this);
    }
}
