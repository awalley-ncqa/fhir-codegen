// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// A record of a medication that is being consumed by a patient.   A MedicationStatement may indicate that the patient may be taking the medication now or has taken the medication in the past or will be taking the medication in the future.  The source of this information can be the patient, significant other (such as a family member or spouse), or a clinician.  A common scenario where this information is captured is during the history taking process during a patient visit or stay.   The medication information may come from sources such as the patient's memory, from a prescription bottle,  or from a list of medications the patient, clinician or other party maintains. 
  /// The primary difference between a medication statement and a medication administration is that the medication administration has complete administration information and is based on actual administration information from the person who administered the medication.  A medication statement is often, if not always, less specific.  There is no required date/time when the medication was administered, in fact we only know that a source has reported the patient is taking this medication, where details such as time, quantity, or rate or even medication product may be incomplete or missing or less precise.  As stated earlier, the medication statement information may come from the patient's memory, from a prescription bottle or from a list of medications the patient, clinician or other party maintains.  Medication administration is more formal and is not missing detailed information.
  /// </summary>
  struct MedicationStatement {
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
    /// This is a business identifier, not a resource identifier.
    /// </summary>
    size_t _identifier_count;
    Identifier** _identifier;
    /// <summary>
    /// A plan, proposal or order that is fulfilled in whole or in part by this event.
    /// </summary>
    size_t _basedOn_count;
    Reference** _basedOn;
    /// <summary>
    /// A larger event of which this particular event is a component or step.
    /// </summary>
    size_t _partOf_count;
    Reference** _partOf;
    /// <summary>
    /// MedicationStatement is a statement at a point in time.  The status is only representative at the point when it was asserted.  The value set for MedicationStatement.status contains codes that assert the status of the use of the medication by the patient (for example, stopped or on hold) as well as codes that assert the status of the medication statement itself (for example, entered in error).
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    NullableString8* _status;
    /// <summary>
    /// This is generally only used for "exception" statuses such as "not-taken", "on-hold", "cancelled" or "entered-in-error". The reason for performing the event at all is captured in reasonCode, not here.
    /// </summary>
    size_t _statusReason_count;
    CodeableConcept** _statusReason;
    /// <summary>
    /// Indicates where the medication is expected to be consumed or administered.
    /// </summary>
    CodeableConcept* _category;
    /// <summary>
    /// If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the medication resource is recommended.  For example, if you require form or lot number, then you must reference the Medication resource.
    /// </summary>
    CodeableConcept* _medicationCodeableConcept;
    /// <summary>
    /// If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the medication resource is recommended.  For example, if you require form or lot number, then you must reference the Medication resource.
    /// </summary>
    Reference* _medicationReference;
    /// <summary>
    /// The person, animal or group who is/was taking the medication.
    /// </summary>
    Reference* _subject;
    /// <summary>
    /// The encounter or episode of care that establishes the context for this MedicationStatement.
    /// </summary>
    Reference* _context;
    /// <summary>
    /// This attribute reflects the period over which the patient consumed the medication and is expected to be populated on the majority of Medication Statements. If the medication is still being taken at the time the statement is recorded, the "end" date will be omitted.  The date/time attribute supports a variety of dates - year, year/month and exact date.  If something more than this is required, this should be conveyed as text.
    /// </summary>
    ISO8601_Time* _effectiveDateTime;
    /// <summary>
    /// This attribute reflects the period over which the patient consumed the medication and is expected to be populated on the majority of Medication Statements. If the medication is still being taken at the time the statement is recorded, the "end" date will be omitted.  The date/time attribute supports a variety of dates - year, year/month and exact date.  If something more than this is required, this should be conveyed as text.
    /// </summary>
    Period* _effectivePeriod;
    /// <summary>
    /// The date when the medication statement was asserted by the information source.
    /// </summary>
    ISO8601_Time* _dateAsserted;
    /// <summary>
    /// The person or organization that provided the information about the taking of this medication. Note: Use derivedFrom when a MedicationStatement is derived from other resources, e.g. Claim or MedicationRequest.
    /// </summary>
    Reference* _informationSource;
    /// <summary>
    /// Likely references would be to MedicationRequest, MedicationDispense, Claim, Observation or QuestionnaireAnswers.  The most common use cases for deriving a MedicationStatement comes from creating a MedicationStatement from a MedicationRequest or from a lab observation or a claim.  it should be noted that the amount of information that is available varies from the type resource that you derive the MedicationStatement from.
    /// </summary>
    size_t _derivedFrom_count;
    Reference** _derivedFrom;
    /// <summary>
    /// This could be a diagnosis code. If a full condition record exists or additional detail is needed, use reasonForUseReference.
    /// </summary>
    size_t _reasonCode_count;
    CodeableConcept** _reasonCode;
    /// <summary>
    /// This is a reference to a condition that is the reason why the medication is being/was taken.  If only a code exists, use reasonForUseCode.
    /// </summary>
    size_t _reasonReference_count;
    Reference** _reasonReference;
    /// <summary>
    /// Provides extra information about the medication statement that is not conveyed by the other attributes.
    /// </summary>
    size_t _note_count;
    Annotation** _note;
    /// <summary>
    /// The dates included in the dosage on a Medication Statement reflect the dates for a given dose.  For example, "from November 1, 2016 to November 3, 2016, take one tablet daily and from November 4, 2016 to November 7, 2016, take two tablets daily."  It is expected that this specificity may only be populated where the patient brings in their labeled container or where the Medication Statement is derived from a MedicationRequest.
    /// </summary>
    size_t _dosage_count;
    Dosage** _dosage;
  };
};