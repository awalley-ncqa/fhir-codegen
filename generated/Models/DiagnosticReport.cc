// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// A list of key images associated with this report. The images are generally created during the diagnostic process, and may be directly of the patient, or of treated specimens (i.e. slides of interest).
  /// </summary>
  struct DiagnosticReportMedia {
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
    /// The comment should be displayed with the image. It would be common for the report to include additional discussion of the image contents in other sections such as the conclusion.
    /// </summary>
    string* _comment;
    /// <summary>
    /// Reference to the image source.
    /// </summary>
    Reference* _link;
  };
  /// <summary>
  /// The findings and interpretation of diagnostic  tests performed on patients, groups of patients, devices, and locations, and/or specimens derived from these. The report includes clinical context such as requesting and provider information, and some mix of atomic results, images, textual and coded interpretations, and formatted representation of diagnostic reports.
  /// </summary>
  struct DiagnosticReport {
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
    /// Usually assigned by the Information System of the diagnostic service provider (filler id).
    /// </summary>
    size_t _identifier_count;
    Identifier** _identifier;
    /// <summary>
    /// Note: Usually there is one test request for each result, however in some circumstances multiple test requests may be represented using a single test result resource. Note that there are also cases where one request leads to multiple reports.
    /// </summary>
    size_t _basedOn_count;
    Reference** _basedOn;
    /// <summary>
    /// The status of the diagnostic report.
    /// </summary>
    NullableString8* _status;
    /// <summary>
    /// Multiple categories are allowed using various categorization schemes.   The level of granularity is defined by the category concepts in the value set. More fine-grained filtering can be performed using the metadata and/or terminology hierarchy in DiagnosticReport.code.
    /// </summary>
    size_t _category_count;
    CodeableConcept** _category;
    /// <summary>
    /// A code or name that describes this diagnostic report.
    /// </summary>
    CodeableConcept* _code;
    /// <summary>
    /// The subject of the report. Usually, but not always, this is a patient. However, diagnostic services also perform analyses on specimens collected from a variety of other sources.
    /// </summary>
    Reference* _subject;
    /// <summary>
    /// This will typically be the encounter the event occurred within, but some events may be initiated prior to or after the official completion of an encounter  but still be tied to the context of the encounter  (e.g. pre-admission laboratory tests).
    /// </summary>
    Reference* _encounter;
    /// <summary>
    /// If the diagnostic procedure was performed on the patient, this is the time it was performed. If there are specimens, the diagnostically relevant time can be derived from the specimen collection times, but the specimen information is not always available, and the exact relationship between the specimens and the diagnostically relevant time is not always automatic.
    /// </summary>
    ISO8601_Time* _effectiveDateTime;
    /// <summary>
    /// If the diagnostic procedure was performed on the patient, this is the time it was performed. If there are specimens, the diagnostically relevant time can be derived from the specimen collection times, but the specimen information is not always available, and the exact relationship between the specimens and the diagnostically relevant time is not always automatic.
    /// </summary>
    Period* _effectivePeriod;
    /// <summary>
    /// May be different from the update time of the resource itself, because that is the status of the record (potentially a secondary copy), not the actual release time of the report.
    /// </summary>
    ISO8601_Time* _issued;
    /// <summary>
    /// This is not necessarily the source of the atomic data items or the entity that interpreted the results. It is the entity that takes responsibility for the clinical report.
    /// </summary>
    size_t _performer_count;
    Reference** _performer;
    /// <summary>
    /// Might not be the same entity that takes responsibility for the clinical report.
    /// </summary>
    size_t _resultsInterpreter_count;
    Reference** _resultsInterpreter;
    /// <summary>
    /// If the specimen is sufficiently specified with a code in the test result name, then this additional data may be redundant. If there are multiple specimens, these may be represented per observation or group.
    /// </summary>
    size_t _specimen_count;
    Reference** _specimen;
    /// <summary>
    /// Observations can contain observations.
    /// </summary>
    size_t _result_count;
    Reference** _result;
    /// <summary>
    /// ImagingStudy and the image element are somewhat overlapping - typically, the list of image references in the image element will also be found in one of the imaging study resources. However, each caters to different types of displays for different types of purposes. Neither, either, or both may be provided.
    /// </summary>
    size_t _imagingStudy_count;
    Reference** _imagingStudy;
    /// <summary>
    /// A list of key images associated with this report. The images are generally created during the diagnostic process, and may be directly of the patient, or of treated specimens (i.e. slides of interest).
    /// </summary>
    size_t _media_count;
    DiagnosticReportMedia** _media;
    /// <summary>
    /// Concise and clinically contextualized summary conclusion (interpretation/impression) of the diagnostic report.
    /// </summary>
    string* _conclusion;
    /// <summary>
    /// One or more codes that represent the summary conclusion (interpretation/impression) of the diagnostic report.
    /// </summary>
    size_t _conclusionCode_count;
    CodeableConcept** _conclusionCode;
    /// <summary>
    /// "application/pdf" is recommended as the most reliable and interoperable in this context.
    /// </summary>
    size_t _presentedForm_count;
    Attachment** _presentedForm;
  };
};