// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// Defines an affiliation/assotiation/relationship between 2 distinct oganizations, that is not a part-of relationship/sub-division relationship.
  /// </summary>
  struct OrganizationAffiliation {
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
    /// Business identifiers that are specific to this role.
    /// </summary>
    size_t _identifier_count;
    Identifier** _identifier;
    /// <summary>
    /// If this value is false, you may refer to the period to see when the role was in active use. If there is no period specified, no inference can be made about when it was active.
    /// </summary>
    NullableBoolean* _active;
    /// <summary>
    /// The period during which the participatingOrganization is affiliated with the primary organization.
    /// </summary>
    Period* _period;
    /// <summary>
    /// Organization where the role is available (primary organization/has members).
    /// </summary>
    Reference* _organization;
    /// <summary>
    /// The Participating Organization provides/performs the role(s) defined by the code to the Primary Organization (e.g. providing services or is a member of).
    /// </summary>
    Reference* _participatingOrganization;
    /// <summary>
    /// Health insurance provider network in which the participatingOrganization provides the role's services (if defined) at the indicated locations (if defined).
    /// </summary>
    size_t _network_count;
    Reference** _network;
    /// <summary>
    /// Definition of the role the participatingOrganization plays in the association.
    /// </summary>
    size_t _code_count;
    CodeableConcept** _code;
    /// <summary>
    /// Specific specialty of the participatingOrganization in the context of the role.
    /// </summary>
    size_t _specialty_count;
    CodeableConcept** _specialty;
    /// <summary>
    /// The location(s) at which the role occurs.
    /// </summary>
    size_t _location_count;
    Reference** _location;
    /// <summary>
    /// Healthcare services provided through the role.
    /// </summary>
    size_t _healthcareService_count;
    Reference** _healthcareService;
    /// <summary>
    /// Contact details at the participatingOrganization relevant to this Affiliation.
    /// </summary>
    size_t _telecom_count;
    ContactPoint** _telecom;
    /// <summary>
    /// Technical endpoints providing access to services operated for this role.
    /// </summary>
    size_t _endpoint_count;
    Reference** _endpoint;
  };
};