// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// If the person who performed the series is not known, their Organization may be recorded. A patient, or related person, may be the performer, e.g. for patient-captured images.
  /// </summary>
  struct ImagingStudySeriesPerformer {
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
    /// Distinguishes the type of involvement of the performer in the series.
    /// </summary>
    CodeableConcept* _function;
    /// <summary>
    /// Indicates who or what performed the series.
    /// </summary>
    Reference* _actor;
  };
  /// <summary>
  /// A single SOP instance within the series, e.g. an image, or presentation state.
  /// </summary>
  struct ImagingStudySeriesInstance {
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
    /// See  [DICOM PS3.3 C.12.1](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.12.html#sect_C.12.1).
    /// </summary>
    NullableString8* _uid;
    /// <summary>
    /// DICOM instance  type.
    /// </summary>
    Coding* _sopClass;
    /// <summary>
    /// The number of instance in the series.
    /// </summary>
    NullableInt32* _number;
    /// <summary>
    /// Particularly for post-acquisition analytic objects, such as SR, presentation states, value mapping, etc.
    /// </summary>
    string* _title;
  };
  /// <summary>
  /// Each study has one or more series of images or other content.
  /// </summary>
  struct ImagingStudySeries {
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
    /// See [DICOM PS3.3 C.7.3](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.7.3.html).
    /// </summary>
    NullableString8* _uid;
    /// <summary>
    /// The numeric identifier of this series in the study.
    /// </summary>
    NullableInt32* _number;
    /// <summary>
    /// The modality of this series sequence.
    /// </summary>
    Coding* _modality;
    /// <summary>
    /// A description of the series.
    /// </summary>
    string* _description;
    /// <summary>
    /// Number of SOP Instances in the Study. The value given may be larger than the number of instance elements this resource contains due to resource availability, security, or other factors. This element should be present if any instance elements are present.
    /// </summary>
    NullableInt32* _numberOfInstances;
    /// <summary>
    /// Typical endpoint types include DICOM WADO-RS, which is used to retrieve DICOM instances in native or rendered (e.g., JPG, PNG) formats using a RESTful API; DICOM WADO-URI, which can similarly retrieve native or rendered instances, except using an HTTP query-based approach; and DICOM QIDO-RS, which allows RESTful query for DICOM information without retrieving the actual instances.
    /// </summary>
    size_t _endpoint_count;
    Reference** _endpoint;
    /// <summary>
    /// The anatomic structures examined. See DICOM Part 16 Annex L (http://dicom.nema.org/medical/dicom/current/output/chtml/part16/chapter_L.html) for DICOM to SNOMED-CT mappings. The bodySite may indicate the laterality of body part imaged; if so, it shall be consistent with any content of ImagingStudy.series.laterality.
    /// </summary>
    Coding* _bodySite;
    /// <summary>
    /// The laterality of the (possibly paired) anatomic structures examined. E.g., the left knee, both lungs, or unpaired abdomen. If present, shall be consistent with any laterality information indicated in ImagingStudy.series.bodySite.
    /// </summary>
    Coding* _laterality;
    /// <summary>
    /// The specimen imaged, e.g., for whole slide imaging of a biopsy.
    /// </summary>
    size_t _specimen_count;
    Reference** _specimen;
    /// <summary>
    /// The date and time the series was started.
    /// </summary>
    ISO8601_Time* _started;
    /// <summary>
    /// If the person who performed the series is not known, their Organization may be recorded. A patient, or related person, may be the performer, e.g. for patient-captured images.
    /// </summary>
    size_t _performer_count;
    ImagingStudySeriesPerformer** _performer;
    /// <summary>
    /// A single SOP instance within the series, e.g. an image, or presentation state.
    /// </summary>
    size_t _instance_count;
    ImagingStudySeriesInstance** _instance;
  };
  /// <summary>
  /// Representation of the content produced in a DICOM imaging study. A study comprises a set of series, each of which includes a set of Service-Object Pair Instances (SOP Instances - images or other data) acquired or produced in a common context.  A series is of only one modality (e.g. X-ray, CT, MR, ultrasound), but a study may have multiple series of different modalities.
  /// </summary>
  struct ImagingStudy {
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
    /// See discussion under [Imaging Study Implementation Notes](imagingstudy.html#notes) for encoding of DICOM Study Instance UID. Accession Number should use ACSN Identifier type.
    /// </summary>
    size_t _identifier_count;
    Identifier** _identifier;
    /// <summary>
    /// Unknown does not represent "other" - one of the defined statuses must apply.  Unknown is used when the authoring system is not sure what the current status is.
    /// </summary>
    NullableString8* _status;
    /// <summary>
    /// A list of all the series.modality values that are actual acquisition modalities, i.e. those in the DICOM Context Group 29 (value set OID 1.2.840.10008.6.1.19).
    /// </summary>
    size_t _modality_count;
    Coding** _modality;
    /// <summary>
    /// QA phantoms can be recorded with a Device; multiple subjects (such as mice) can be recorded with a Group.
    /// </summary>
    Reference* _subject;
    /// <summary>
    /// This will typically be the encounter the event occurred within, but some events may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter (e.g. pre-admission test).
    /// </summary>
    Reference* _encounter;
    /// <summary>
    /// Date and time the study started.
    /// </summary>
    ISO8601_Time* _started;
    /// <summary>
    /// A list of the diagnostic requests that resulted in this imaging study being performed.
    /// </summary>
    size_t _basedOn_count;
    Reference** _basedOn;
    /// <summary>
    /// The requesting/referring physician.
    /// </summary>
    Reference* _referrer;
    /// <summary>
    /// Who read the study and interpreted the images or other content.
    /// </summary>
    size_t _interpreter_count;
    Reference** _interpreter;
    /// <summary>
    /// Typical endpoint types include DICOM WADO-RS, which is used to retrieve DICOM instances in native or rendered (e.g., JPG, PNG), formats using a RESTful API; DICOM WADO-URI, which can similarly retrieve native or rendered instances, except using an HTTP query-based approach; DICOM QIDO-RS, which allows RESTful query for DICOM information without retrieving the actual instances; or IHE Invoke Image Display (IID), which provides standard invocation of an imaging web viewer.
    /// </summary>
    size_t _endpoint_count;
    Reference** _endpoint;
    /// <summary>
    /// Number of Series in the Study. This value given may be larger than the number of series elements this Resource contains due to resource availability, security, or other factors. This element should be present if any series elements are present.
    /// </summary>
    NullableInt32* _numberOfSeries;
    /// <summary>
    /// Number of SOP Instances in Study. This value given may be larger than the number of instance elements this resource contains due to resource availability, security, or other factors. This element should be present if any instance elements are present.
    /// </summary>
    NullableInt32* _numberOfInstances;
    /// <summary>
    /// The procedure which this ImagingStudy was part of.
    /// </summary>
    Reference* _procedureReference;
    /// <summary>
    /// The code for the performed procedure type.
    /// </summary>
    size_t _procedureCode_count;
    CodeableConcept** _procedureCode;
    /// <summary>
    /// The principal physical location where the ImagingStudy was performed.
    /// </summary>
    Reference* _location;
    /// <summary>
    /// Description of clinical condition indicating why the ImagingStudy was requested.
    /// </summary>
    size_t _reasonCode_count;
    CodeableConcept** _reasonCode;
    /// <summary>
    /// Indicates another resource whose existence justifies this Study.
    /// </summary>
    size_t _reasonReference_count;
    Reference** _reasonReference;
    /// <summary>
    /// Per the recommended DICOM mapping, this element is derived from the Study Description attribute (0008,1030). Observations or findings about the imaging study should be recorded in another resource, e.g. Observation, and not in this element.
    /// </summary>
    size_t _note_count;
    Annotation** _note;
    /// <summary>
    /// The Imaging Manager description of the study. Institution-generated description or classification of the Study (component) performed.
    /// </summary>
    string* _description;
    /// <summary>
    /// Each study has one or more series of images or other content.
    /// </summary>
    size_t _series_count;
    ImagingStudySeries** _series;
  };
};