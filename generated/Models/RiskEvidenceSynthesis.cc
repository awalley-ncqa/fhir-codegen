// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// A description of the size of the sample involved in the synthesis.
  /// </summary>
  struct RiskEvidenceSynthesisSampleSize {
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
    /// Human-readable summary of sample size.
    /// </summary>
    string* _description;
    /// <summary>
    /// Number of studies included in this evidence synthesis.
    /// </summary>
    NullableInt32* _numberOfStudies;
    /// <summary>
    /// Number of participants included in this evidence synthesis.
    /// </summary>
    NullableInt32* _numberOfParticipants;
  };
  /// <summary>
  /// A description of the precision of the estimate for the effect.
  /// </summary>
  struct RiskEvidenceSynthesisRiskEstimatePrecisionEstimate {
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
    /// Examples include confidence interval and interquartile range.
    /// </summary>
    CodeableConcept* _type;
    /// <summary>
    /// Use 95 for a 95% confidence interval.
    /// </summary>
    NullableString8* _level;
    /// <summary>
    /// Lower bound of confidence interval.
    /// </summary>
    NullableString8* _from;
    /// <summary>
    /// Upper bound of confidence interval.
    /// </summary>
    NullableString8* _to;
  };
  /// <summary>
  /// The estimated risk of the outcome.
  /// </summary>
  struct RiskEvidenceSynthesisRiskEstimate {
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
    /// Human-readable summary of risk estimate.
    /// </summary>
    string* _description;
    /// <summary>
    /// Examples include proportion and mean.
    /// </summary>
    CodeableConcept* _type;
    /// <summary>
    /// The point estimate of the risk estimate.
    /// </summary>
    NullableString8* _value;
    /// <summary>
    /// Specifies the UCUM unit for the outcome.
    /// </summary>
    CodeableConcept* _unitOfMeasure;
    /// <summary>
    /// The sample size for the group that was measured for this risk estimate.
    /// </summary>
    NullableInt32* _denominatorCount;
    /// <summary>
    /// The number of group members with the outcome of interest.
    /// </summary>
    NullableInt32* _numeratorCount;
    /// <summary>
    /// A description of the precision of the estimate for the effect.
    /// </summary>
    size_t _precisionEstimate_count;
    RiskEvidenceSynthesisRiskEstimatePrecisionEstimate** _precisionEstimate;
  };
  /// <summary>
  /// A description of a component of the overall certainty.
  /// </summary>
  struct RiskEvidenceSynthesisCertaintyCertaintySubcomponent {
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
    /// Type of subcomponent of certainty rating.
    /// </summary>
    CodeableConcept* _type;
    /// <summary>
    /// A rating of a subcomponent of rating certainty.
    /// </summary>
    size_t _rating_count;
    CodeableConcept** _rating;
    /// <summary>
    /// A human-readable string to clarify or explain concepts about the resource.
    /// </summary>
    size_t _note_count;
    Annotation** _note;
  };
  /// <summary>
  /// A description of the certainty of the risk estimate.
  /// </summary>
  struct RiskEvidenceSynthesisCertainty {
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
    /// A rating of the certainty of the effect estimate.
    /// </summary>
    size_t _rating_count;
    CodeableConcept** _rating;
    /// <summary>
    /// A human-readable string to clarify or explain concepts about the resource.
    /// </summary>
    size_t _note_count;
    Annotation** _note;
    /// <summary>
    /// A description of a component of the overall certainty.
    /// </summary>
    size_t _certaintySubcomponent_count;
    RiskEvidenceSynthesisCertaintyCertaintySubcomponent** _certaintySubcomponent;
  };
  /// <summary>
  /// The RiskEvidenceSynthesis resource describes the likelihood of an outcome in a population plus exposure state where the risk estimate is derived from a combination of research studies.
  /// </summary>
  struct RiskEvidenceSynthesis {
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
    /// Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this risk evidence synthesis outside of FHIR, where it is not possible to use the logical URI.
    /// </summary>
    size_t _identifier_count;
    Identifier** _identifier;
    /// <summary>
    /// There may be different risk evidence synthesis instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the risk evidence synthesis with the format [url]|[version].
    /// </summary>
    string* _version;
    /// <summary>
    /// The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.
    /// </summary>
    string* _name;
    /// <summary>
    /// This name does not need to be machine-processing friendly and may contain punctuation, white-space, etc.
    /// </summary>
    string* _title;
    /// <summary>
    /// Allows filtering of risk evidence synthesiss that are appropriate for use versus not.
    /// </summary>
    NullableString8* _status;
    /// <summary>
    /// Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the risk evidence synthesis. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.
    /// </summary>
    ISO8601_Time* _date;
    /// <summary>
    /// Usually an organization but may be an individual. The publisher (or steward) of the risk evidence synthesis is the organization or individual primarily responsible for the maintenance and upkeep of the risk evidence synthesis. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the risk evidence synthesis. This item SHOULD be populated unless the information is available from context.
    /// </summary>
    string* _publisher;
    /// <summary>
    /// May be a web site, an email address, a telephone number, etc.
    /// </summary>
    size_t _contact_count;
    ContactDetail** _contact;
    /// <summary>
    /// This description can be used to capture details such as why the risk evidence synthesis was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the risk evidence synthesis as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the risk evidence synthesis is presumed to be the predominant language in the place the risk evidence synthesis was created).
    /// </summary>
    NullableString8* _description;
    /// <summary>
    /// A human-readable string to clarify or explain concepts about the resource.
    /// </summary>
    size_t _note_count;
    Annotation** _note;
    /// <summary>
    /// When multiple useContexts are specified, there is no expectation that all or any of the contexts apply.
    /// </summary>
    size_t _useContext_count;
    UsageContext** _useContext;
    /// <summary>
    /// It may be possible for the risk evidence synthesis to be used in jurisdictions other than those for which it was originally designed or intended.
    /// </summary>
    size_t _jurisdiction_count;
    CodeableConcept** _jurisdiction;
    /// <summary>
    /// A copyright statement relating to the risk evidence synthesis and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the risk evidence synthesis.
    /// </summary>
    NullableString8* _copyright;
    /// <summary>
    /// The 'date' element may be more recent than the approval date because of minor changes or editorial corrections.
    /// </summary>
    ISO8601_Time* _approvalDate;
    /// <summary>
    /// If specified, this date follows the original approval date.
    /// </summary>
    ISO8601_Time* _lastReviewDate;
    /// <summary>
    /// The effective period for a risk evidence synthesis  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.
    /// </summary>
    Period* _effectivePeriod;
    /// <summary>
    /// Descriptive topics related to the content of the RiskEvidenceSynthesis. Topics provide a high-level categorization grouping types of EffectEvidenceSynthesiss that can be useful for filtering and searching.
    /// </summary>
    size_t _topic_count;
    CodeableConcept** _topic;
    /// <summary>
    /// An individiual or organization primarily involved in the creation and maintenance of the content.
    /// </summary>
    size_t _author_count;
    ContactDetail** _author;
    /// <summary>
    /// An individual or organization primarily responsible for internal coherence of the content.
    /// </summary>
    size_t _editor_count;
    ContactDetail** _editor;
    /// <summary>
    /// An individual or organization primarily responsible for review of some aspect of the content.
    /// </summary>
    size_t _reviewer_count;
    ContactDetail** _reviewer;
    /// <summary>
    /// An individual or organization responsible for officially endorsing the content for use in some setting.
    /// </summary>
    size_t _endorser_count;
    ContactDetail** _endorser;
    /// <summary>
    /// Each related artifact is either an attachment, or a reference to another resource, but not both.
    /// </summary>
    size_t _relatedArtifact_count;
    RelatedArtifact** _relatedArtifact;
    /// <summary>
    /// Type of synthesis eg meta-analysis.
    /// </summary>
    CodeableConcept* _synthesisType;
    /// <summary>
    /// Type of study eg randomized trial.
    /// </summary>
    CodeableConcept* _studyType;
    /// <summary>
    /// A reference to a EvidenceVariable resource that defines the population for the research.
    /// </summary>
    Reference* _population;
    /// <summary>
    /// A reference to a EvidenceVariable resource that defines the exposure for the research.
    /// </summary>
    Reference* _exposure;
    /// <summary>
    /// A reference to a EvidenceVariable resomece that defines the outcome for the research.
    /// </summary>
    Reference* _outcome;
    /// <summary>
    /// A description of the size of the sample involved in the synthesis.
    /// </summary>
    RiskEvidenceSynthesisSampleSize* _sampleSize;
    /// <summary>
    /// The estimated risk of the outcome.
    /// </summary>
    RiskEvidenceSynthesisRiskEstimate* _riskEstimate;
    /// <summary>
    /// A description of the certainty of the risk estimate.
    /// </summary>
    size_t _certainty_count;
    RiskEvidenceSynthesisCertainty** _certainty;
  };
};