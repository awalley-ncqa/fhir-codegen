// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// Compartment Consistency Rules.
  /// </summary>
  struct GraphDefinitionLinkTargetCompartment {
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.
    /// </summary>
    string _id;
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    size_t _extension_count;
    Extension** _extension;
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    size_t _modifierExtension_count;
    Extension** _modifierExtension;
    /// <summary>
    /// All conditional rules are evaluated; if they are true, then the rules are evaluated.
    /// </summary>
    NullableString8* _use;
    /// <summary>
    /// Identifies the compartment.
    /// </summary>
    NullableString8* _code;
    /// <summary>
    /// identical | matching | different | no-rule | custom.
    /// </summary>
    NullableString8* _rule;
    /// <summary>
    /// Custom rule, as a FHIRPath expression.
    /// </summary>
    string* _expression;
    /// <summary>
    /// Documentation for FHIRPath expression.
    /// </summary>
    string* _description;
  };
  /// <summary>
  /// Potential target for the link.
  /// </summary>
  struct GraphDefinitionLinkTarget {
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.
    /// </summary>
    string _id;
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    size_t _extension_count;
    Extension** _extension;
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    size_t _modifierExtension_count;
    Extension** _modifierExtension;
    /// <summary>
    /// Type of resource this link refers to.
    /// </summary>
    NullableString8* _type;
    /// <summary>
    /// At least one of the parameters must have the value {ref} which identifies the focus resource.
    /// </summary>
    string* _params;
    /// <summary>
    /// Profile for the target resource.
    /// </summary>
    NullableString8* _profile;
    /// <summary>
    /// Compartment Consistency Rules.
    /// </summary>
    size_t _compartment_count;
    GraphDefinitionLinkTargetCompartment** _compartment;
    /// <summary>
    /// Additional links from target resource.
    /// </summary>
    size_t _link_count;
    GraphDefinitionLink** _link;
  };
  /// <summary>
  /// Links this graph makes rules about.
  /// </summary>
  struct GraphDefinitionLink {
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.
    /// </summary>
    string _id;
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    size_t _extension_count;
    Extension** _extension;
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    size_t _modifierExtension_count;
    Extension** _modifierExtension;
    /// <summary>
    /// The path expression cannot contain a resolve() function. If there is no path, the link is a reverse lookup, using target.params. If the path is "*" then this means all references in the resource.
    /// </summary>
    string* _path;
    /// <summary>
    /// Which slice (if profiled).
    /// </summary>
    string* _sliceName;
    /// <summary>
    /// Minimum occurrences for this link.
    /// </summary>
    NullableInt32* _min;
    /// <summary>
    /// Maximum occurrences for this link.
    /// </summary>
    string* _max;
    /// <summary>
    /// Information about why this link is of interest in this graph definition.
    /// </summary>
    string* _description;
    /// <summary>
    /// Potential target for the link.
    /// </summary>
    size_t _target_count;
    GraphDefinitionLinkTarget** _target;
  };
  /// <summary>
  /// A formal computable definition of a graph of resources - that is, a coherent set of resources that form a graph by following references. The Graph Definition resource defines a set and makes rules about the set.
  /// </summary>
  struct GraphDefinition {
    ResourceType resourceType;
    /// <summary>
    /// The only time that a resource does not have an id is when it is being submitted to the server using a create operation.
    /// </summary>
    string _id;
    /// <summary>
    /// The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.
    /// </summary>
    Meta* _meta;
    /// <summary>
    /// Asserting this rule set restricts the content to be only understood by a limited set of trading partners. This inherently limits the usefulness of the data in the long term. However, the existing health eco-system is highly fractured, and not yet ready to define, collect, and exchange data in a generally computable sense. Wherever possible, implementers and/or specification writers should avoid using this element. Often, when used, the URL is a reference to an implementation guide that defines these special rules as part of it's narrative along with other profiles, value sets, etc.
    /// </summary>
    NullableString8* _implicitRules;
    /// <summary>
    /// Language is provided to support indexing and accessibility (typically, services such as text to speech use the language tag). The html language tag in the narrative applies  to the narrative. The language tag on the resource may be used to specify the language of other presentations generated from the data in the resource. Not all the content has to be in the base language. The Resource.language should not be assumed to apply to the narrative automatically. If a language is specified, it should it also be specified on the div element in the html (see rules in HTML5 for information about the relationship between xml:lang and the html lang attribute).
    /// </summary>
    NullableString8* _language;
    /// <summary>
    /// Contained resources do not have narrative. Resources that are not contained SHOULD have a narrative. In some cases, a resource may only have text with little or no additional discrete data (as long as all minOccurs=1 elements are satisfied).  This may be necessary for data from legacy systems where information is captured as a "text blob" or where text is additionally entered raw or narrated and encoded information is added later.
    /// </summary>
    Narrative* _text;
    /// <summary>
    /// This should never be done when the content can be identified properly, as once identification is lost, it is extremely difficult (and context dependent) to restore it again. Contained resources may have profiles and tags In their meta elements, but SHALL NOT have security labels.
    /// </summary>
    size_t _contained_count;
    Resource** _contained;
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    size_t _extension_count;
    Extension** _extension;
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    size_t _modifierExtension_count;
    Extension** _modifierExtension;
    /// <summary>
    /// Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.
    /// The determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). 
    /// In some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.
    /// </summary>
    NullableString8* _url;
    /// <summary>
    /// There may be different graph definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the graph definition with the format [url]|[version].
    /// </summary>
    string* _version;
    /// <summary>
    /// The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.
    /// </summary>
    string* _name;
    /// <summary>
    /// Allows filtering of graph definitions that are appropriate for use versus not.
    /// </summary>
    NullableString8* _status;
    /// <summary>
    /// Allows filtering of graph definitions that are appropriate for use versus not.
    /// </summary>
    NullableBoolean* _experimental;
    /// <summary>
    /// Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the graph definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.
    /// </summary>
    ISO8601_Time* _date;
    /// <summary>
    /// Usually an organization but may be an individual. The publisher (or steward) of the graph definition is the organization or individual primarily responsible for the maintenance and upkeep of the graph definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the graph definition. This item SHOULD be populated unless the information is available from context.
    /// </summary>
    string* _publisher;
    /// <summary>
    /// May be a web site, an email address, a telephone number, etc.
    /// </summary>
    size_t _contact_count;
    ContactDetail** _contact;
    /// <summary>
    /// This description can be used to capture details such as why the graph definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the graph definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the graph definition is presumed to be the predominant language in the place the graph definition was created).
    /// </summary>
    NullableString8* _description;
    /// <summary>
    /// When multiple useContexts are specified, there is no expectation that all or any of the contexts apply.
    /// </summary>
    size_t _useContext_count;
    UsageContext** _useContext;
    /// <summary>
    /// It may be possible for the graph definition to be used in jurisdictions other than those for which it was originally designed or intended.
    /// </summary>
    size_t _jurisdiction_count;
    CodeableConcept** _jurisdiction;
    /// <summary>
    /// This element does not describe the usage of the graph definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this graph definition.
    /// </summary>
    NullableString8* _purpose;
    /// <summary>
    /// The type of FHIR resource at which instances of this graph start.
    /// </summary>
    NullableString8* _start;
    /// <summary>
    /// The code does not include the '$' prefix that is always included in the URL when the operation is invoked.
    /// </summary>
    NullableString8* _profile;
    /// <summary>
    /// Links this graph makes rules about.
    /// </summary>
    size_t _link_count;
    GraphDefinitionLink** _link;
  };
};