// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// If this item is a group then the values here are a summary of the adjudication of the detail items. If this item is a simple product or service then this is the result of the adjudication of this item.
  /// </summary>
  struct ClaimResponseItemAdjudication {
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
    /// For example codes indicating: Co-Pay, deductible, eligible, benefit, tax, etc.
    /// </summary>
    CodeableConcept* _category;
    /// <summary>
    /// For example may indicate that the funds for this benefit type have been exhausted.
    /// </summary>
    CodeableConcept* _reason;
    /// <summary>
    /// For example: amount submitted, eligible amount, co-payment, and benefit payable.
    /// </summary>
    Money* _amount;
    /// <summary>
    /// For example: eligible percentage or co-payment percentage.
    /// </summary>
    NullableString8* _value;
  };
  /// <summary>
  /// A sub-detail adjudication of a simple product or service.
  /// </summary>
  struct ClaimResponseItemDetailSubDetail {
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
    /// A number to uniquely reference the claim sub-detail entry.
    /// </summary>
    NullableInt32* _subDetailSequence;
    /// <summary>
    /// The numbers associated with notes below which apply to the adjudication of this item.
    /// </summary>
    size_t _noteNumber_count;
    NullableInt32** _noteNumber;
    /// <summary>
    /// The adjudication results.
    /// </summary>
    size_t _adjudication_count;
    ClaimResponseItemAdjudication** _adjudication;
  };
  /// <summary>
  /// A claim detail. Either a simple (a product or service) or a 'group' of sub-details which are simple items.
  /// </summary>
  struct ClaimResponseItemDetail {
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
    /// A number to uniquely reference the claim detail entry.
    /// </summary>
    NullableInt32* _detailSequence;
    /// <summary>
    /// The numbers associated with notes below which apply to the adjudication of this item.
    /// </summary>
    size_t _noteNumber_count;
    NullableInt32** _noteNumber;
    /// <summary>
    /// The adjudication results.
    /// </summary>
    size_t _adjudication_count;
    ClaimResponseItemAdjudication** _adjudication;
    /// <summary>
    /// A sub-detail adjudication of a simple product or service.
    /// </summary>
    size_t _subDetail_count;
    ClaimResponseItemDetailSubDetail** _subDetail;
  };
  /// <summary>
  /// A claim line. Either a simple (a product or service) or a 'group' of details which can also be a simple items or groups of sub-details.
  /// </summary>
  struct ClaimResponseItem {
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
    /// A number to uniquely reference the claim item entries.
    /// </summary>
    NullableInt32* _itemSequence;
    /// <summary>
    /// The numbers associated with notes below which apply to the adjudication of this item.
    /// </summary>
    size_t _noteNumber_count;
    NullableInt32** _noteNumber;
    /// <summary>
    /// If this item is a group then the values here are a summary of the adjudication of the detail items. If this item is a simple product or service then this is the result of the adjudication of this item.
    /// </summary>
    size_t _adjudication_count;
    ClaimResponseItemAdjudication** _adjudication;
    /// <summary>
    /// A claim detail. Either a simple (a product or service) or a 'group' of sub-details which are simple items.
    /// </summary>
    size_t _detail_count;
    ClaimResponseItemDetail** _detail;
  };
  /// <summary>
  /// The third-tier service adjudications for payor added services.
  /// </summary>
  struct ClaimResponseAddItemDetailSubDetail {
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
    /// If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.
    /// </summary>
    CodeableConcept* _productOrService;
    /// <summary>
    /// For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or outside of office hours.
    /// </summary>
    size_t _modifier_count;
    CodeableConcept** _modifier;
    /// <summary>
    /// The number of repetitions of a service or product.
    /// </summary>
    Quantity* _quantity;
    /// <summary>
    /// If the item is not a group then this is the fee for the product or service, otherwise this is the total of the fees for the details of the group.
    /// </summary>
    Money* _unitPrice;
    /// <summary>
    /// To show a 10% senior's discount, the value entered is: 0.90 (1.00 - 0.10).
    /// </summary>
    NullableString8* _factor;
    /// <summary>
    /// For example, the formula: quantity * unitPrice * factor  = net. Quantity and factor are assumed to be 1 if not supplied.
    /// </summary>
    Money* _net;
    /// <summary>
    /// The numbers associated with notes below which apply to the adjudication of this item.
    /// </summary>
    size_t _noteNumber_count;
    NullableInt32** _noteNumber;
    /// <summary>
    /// The adjudication results.
    /// </summary>
    size_t _adjudication_count;
    ClaimResponseItemAdjudication** _adjudication;
  };
  /// <summary>
  /// The second-tier service adjudications for payor added services.
  /// </summary>
  struct ClaimResponseAddItemDetail {
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
    /// If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.
    /// </summary>
    CodeableConcept* _productOrService;
    /// <summary>
    /// For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or outside of office hours.
    /// </summary>
    size_t _modifier_count;
    CodeableConcept** _modifier;
    /// <summary>
    /// The number of repetitions of a service or product.
    /// </summary>
    Quantity* _quantity;
    /// <summary>
    /// If the item is not a group then this is the fee for the product or service, otherwise this is the total of the fees for the details of the group.
    /// </summary>
    Money* _unitPrice;
    /// <summary>
    /// To show a 10% senior's discount, the value entered is: 0.90 (1.00 - 0.10).
    /// </summary>
    NullableString8* _factor;
    /// <summary>
    /// For example, the formula: quantity * unitPrice * factor  = net. Quantity and factor are assumed to be 1 if not supplied.
    /// </summary>
    Money* _net;
    /// <summary>
    /// The numbers associated with notes below which apply to the adjudication of this item.
    /// </summary>
    size_t _noteNumber_count;
    NullableInt32** _noteNumber;
    /// <summary>
    /// The adjudication results.
    /// </summary>
    size_t _adjudication_count;
    ClaimResponseItemAdjudication** _adjudication;
    /// <summary>
    /// The third-tier service adjudications for payor added services.
    /// </summary>
    size_t _subDetail_count;
    ClaimResponseAddItemDetailSubDetail** _subDetail;
  };
  /// <summary>
  /// The first-tier service adjudications for payor added product or service lines.
  /// </summary>
  struct ClaimResponseAddItem {
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
    /// Claim items which this service line is intended to replace.
    /// </summary>
    size_t _itemSequence_count;
    NullableInt32** _itemSequence;
    /// <summary>
    /// The sequence number of the details within the claim item which this line is intended to replace.
    /// </summary>
    size_t _detailSequence_count;
    NullableInt32** _detailSequence;
    /// <summary>
    /// The sequence number of the sub-details within the details within the claim item which this line is intended to replace.
    /// </summary>
    size_t _subdetailSequence_count;
    NullableInt32** _subdetailSequence;
    /// <summary>
    /// The providers who are authorized for the services rendered to the patient.
    /// </summary>
    size_t _provider_count;
    Reference** _provider;
    /// <summary>
    /// If this is an actual service or product line, i.e. not a Group, then use code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI). If a grouping item then use a group code to indicate the type of thing being grouped e.g. 'glasses' or 'compound'.
    /// </summary>
    CodeableConcept* _productOrService;
    /// <summary>
    /// For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or outside of office hours.
    /// </summary>
    size_t _modifier_count;
    CodeableConcept** _modifier;
    /// <summary>
    /// For example: Neonatal program, child dental program or drug users recovery program.
    /// </summary>
    size_t _programCode_count;
    CodeableConcept** _programCode;
    /// <summary>
    /// The date or dates when the service or product was supplied, performed or completed.
    /// </summary>
    ISO8601_Time* _servicedDate;
    /// <summary>
    /// The date or dates when the service or product was supplied, performed or completed.
    /// </summary>
    Period* _servicedPeriod;
    /// <summary>
    /// Where the product or service was provided.
    /// </summary>
    CodeableConcept* _locationCodeableConcept;
    /// <summary>
    /// Where the product or service was provided.
    /// </summary>
    Address* _locationAddress;
    /// <summary>
    /// Where the product or service was provided.
    /// </summary>
    Reference* _locationReference;
    /// <summary>
    /// The number of repetitions of a service or product.
    /// </summary>
    Quantity* _quantity;
    /// <summary>
    /// If the item is not a group then this is the fee for the product or service, otherwise this is the total of the fees for the details of the group.
    /// </summary>
    Money* _unitPrice;
    /// <summary>
    /// To show a 10% senior's discount, the value entered is: 0.90 (1.00 - 0.10).
    /// </summary>
    NullableString8* _factor;
    /// <summary>
    /// For example, the formula: quantity * unitPrice * factor  = net. Quantity and factor are assumed to be 1 if not supplied.
    /// </summary>
    Money* _net;
    /// <summary>
    /// For example: Providing a tooth code allows an insurer to identify a provider performing a filling on a tooth that was previously removed.
    /// </summary>
    CodeableConcept* _bodySite;
    /// <summary>
    /// A region or surface of the bodySite, e.g. limb region or tooth surface(s).
    /// </summary>
    size_t _subSite_count;
    CodeableConcept** _subSite;
    /// <summary>
    /// The numbers associated with notes below which apply to the adjudication of this item.
    /// </summary>
    size_t _noteNumber_count;
    NullableInt32** _noteNumber;
    /// <summary>
    /// The adjudication results.
    /// </summary>
    size_t _adjudication_count;
    ClaimResponseItemAdjudication** _adjudication;
    /// <summary>
    /// The second-tier service adjudications for payor added services.
    /// </summary>
    size_t _detail_count;
    ClaimResponseAddItemDetail** _detail;
  };
  /// <summary>
  /// Totals for amounts submitted, co-pays, benefits payable etc.
  /// </summary>
  struct ClaimResponseTotal {
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
    /// For example codes indicating: Co-Pay, deductible, eligible, benefit, tax, etc.
    /// </summary>
    CodeableConcept* _category;
    /// <summary>
    /// Monetary total amount associated with the category.
    /// </summary>
    Money* _amount;
  };
  /// <summary>
  /// Payment details for the adjudication of the claim.
  /// </summary>
  struct ClaimResponsePayment {
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
    /// Whether this represents partial or complete payment of the benefits payable.
    /// </summary>
    CodeableConcept* _type;
    /// <summary>
    /// Insurers will deduct amounts owing from the provider (adjustment), such as a prior overpayment, from the amount owing to the provider (benefits payable) when payment is made to the provider.
    /// </summary>
    Money* _adjustment;
    /// <summary>
    /// Reason for the payment adjustment.
    /// </summary>
    CodeableConcept* _adjustmentReason;
    /// <summary>
    /// Estimated date the payment will be issued or the actual issue date of payment.
    /// </summary>
    ISO8601_Time* _date;
    /// <summary>
    /// Benefits payable less any payment adjustment.
    /// </summary>
    Money* _amount;
    /// <summary>
    /// For example: EFT number or check number.
    /// </summary>
    Identifier* _identifier;
  };
  /// <summary>
  /// A note that describes or explains adjudication results in a human readable form.
  /// </summary>
  struct ClaimResponseProcessNote {
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
    /// A number to uniquely identify a note entry.
    /// </summary>
    NullableInt32* _number;
    /// <summary>
    /// The business purpose of the note text.
    /// </summary>
    NullableString8* _type;
    /// <summary>
    /// The explanation or description associated with the processing.
    /// </summary>
    string* _text;
    /// <summary>
    /// Only required if the language is different from the resource language.
    /// </summary>
    CodeableConcept* _language;
  };
  /// <summary>
  /// All insurance coverages for the patient which may be applicable for reimbursement, of the products and services listed in the claim, are typically provided in the claim to allow insurers to confirm the ordering of the insurance coverages relative to local 'coordination of benefit' rules. One coverage (and only one) with 'focal=true' is to be used in the adjudication of this claim. Coverages appearing before the focal Coverage in the list, and where 'subrogation=false', should provide a reference to the ClaimResponse containing the adjudication results of the prior claim.
  /// </summary>
  struct ClaimResponseInsurance {
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
    /// A number to uniquely identify insurance entries and provide a sequence of coverages to convey coordination of benefit order.
    /// </summary>
    NullableInt32* _sequence;
    /// <summary>
    /// A patient may (will) have multiple insurance policies which provide reimbursement for healthcare services and products. For example a person may also be covered by their spouse's policy and both appear in the list (and may be from the same insurer). This flag will be set to true for only one of the listed policies and that policy will be used for adjudicating this claim. Other claims would be created to request adjudication against the other listed policies.
    /// </summary>
    NullableBoolean* _focal;
    /// <summary>
    /// Reference to the insurance card level information contained in the Coverage resource. The coverage issuing insurer will use these details to locate the patient's actual coverage within the insurer's information system.
    /// </summary>
    Reference* _coverage;
    /// <summary>
    /// A business agreement number established between the provider and the insurer for special business processing purposes.
    /// </summary>
    string* _businessArrangement;
    /// <summary>
    /// Must not be specified when 'focal=true' for this insurance.
    /// </summary>
    Reference* _claimResponse;
  };
  /// <summary>
  /// If the request contains errors then an error element should be provided and no adjudication related sections (item, addItem, or payment) should be present.
  /// </summary>
  struct ClaimResponseError {
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
    /// The sequence number of the line item submitted which contains the error. This value is omitted when the error occurs outside of the item structure.
    /// </summary>
    NullableInt32* _itemSequence;
    /// <summary>
    /// The sequence number of the detail within the line item submitted which contains the error. This value is omitted when the error occurs outside of the item structure.
    /// </summary>
    NullableInt32* _detailSequence;
    /// <summary>
    /// The sequence number of the sub-detail within the detail within the line item submitted which contains the error. This value is omitted when the error occurs outside of the item structure.
    /// </summary>
    NullableInt32* _subDetailSequence;
    /// <summary>
    /// An error code, from a specified code system, which details why the claim could not be adjudicated.
    /// </summary>
    CodeableConcept* _code;
  };
  /// <summary>
  /// This resource provides the adjudication details from the processing of a Claim resource.
  /// </summary>
  struct ClaimResponse {
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
    /// A unique identifier assigned to this claim response.
    /// </summary>
    size_t _identifier_count;
    Identifier** _identifier;
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    NullableString8* _status;
    /// <summary>
    /// This may contain the local bill type codes, for example the US UB-04 bill type code or the CMS bill type.
    /// </summary>
    CodeableConcept* _type;
    /// <summary>
    /// This may contain the local bill type codes, for example the US UB-04 bill type code or the CMS bill type.
    /// </summary>
    CodeableConcept* _subType;
    /// <summary>
    /// A code to indicate whether the nature of the request is: to request adjudication of products and services previously rendered; or requesting authorization and adjudication for provision in the future; or requesting the non-binding adjudication of the listed products and services which could be provided in the future.
    /// </summary>
    NullableString8* _use;
    /// <summary>
    /// The party to whom the professional services and/or products have been supplied or are being considered and for whom actual for facast reimbursement is sought.
    /// </summary>
    Reference* _patient;
    /// <summary>
    /// The date this resource was created.
    /// </summary>
    ISO8601_Time* _created;
    /// <summary>
    /// The party responsible for authorization, adjudication and reimbursement.
    /// </summary>
    Reference* _insurer;
    /// <summary>
    /// Typically this field would be 1..1 where this party is responsible for the claim but not necessarily professionally responsible for the provision of the individual products and services listed below.
    /// </summary>
    Reference* _requestor;
    /// <summary>
    /// Original request resource reference.
    /// </summary>
    Reference* _request;
    /// <summary>
    /// The resource may be used to indicate that: the request has been held (queued) for processing; that it has been processed and errors found (error); that no errors were found and that some of the adjudication has been undertaken (partial) or that all of the adjudication has been undertaken (complete).
    /// </summary>
    NullableString8* _outcome;
    /// <summary>
    /// A human readable description of the status of the adjudication.
    /// </summary>
    string* _disposition;
    /// <summary>
    /// This value is only present on preauthorization adjudications.
    /// </summary>
    string* _preAuthRef;
    /// <summary>
    /// The time frame during which this authorization is effective.
    /// </summary>
    Period* _preAuthPeriod;
    /// <summary>
    /// Type of Party to be reimbursed: subscriber, provider, other.
    /// </summary>
    CodeableConcept* _payeeType;
    /// <summary>
    /// A claim line. Either a simple (a product or service) or a 'group' of details which can also be a simple items or groups of sub-details.
    /// </summary>
    size_t _item_count;
    ClaimResponseItem** _item;
    /// <summary>
    /// The first-tier service adjudications for payor added product or service lines.
    /// </summary>
    size_t _addItem_count;
    ClaimResponseAddItem** _addItem;
    /// <summary>
    /// The adjudication results which are presented at the header level rather than at the line-item or add-item levels.
    /// </summary>
    size_t _adjudication_count;
    ClaimResponseItemAdjudication** _adjudication;
    /// <summary>
    /// Totals for amounts submitted, co-pays, benefits payable etc.
    /// </summary>
    size_t _total_count;
    ClaimResponseTotal** _total;
    /// <summary>
    /// Payment details for the adjudication of the claim.
    /// </summary>
    ClaimResponsePayment* _payment;
    /// <summary>
    /// Fund would be release by a future claim quoting the preAuthRef of this response. Examples of values include: provider, patient, none.
    /// </summary>
    CodeableConcept* _fundsReserve;
    /// <summary>
    /// May be needed to identify specific jurisdictional forms.
    /// </summary>
    CodeableConcept* _formCode;
    /// <summary>
    /// Needed to permit insurers to include the actual form.
    /// </summary>
    Attachment* _form;
    /// <summary>
    /// A note that describes or explains adjudication results in a human readable form.
    /// </summary>
    size_t _processNote_count;
    ClaimResponseProcessNote** _processNote;
    /// <summary>
    /// For example: professional reports, documents, images, clinical resources, or accident reports.
    /// </summary>
    size_t _communicationRequest_count;
    Reference** _communicationRequest;
    /// <summary>
    /// All insurance coverages for the patient which may be applicable for reimbursement, of the products and services listed in the claim, are typically provided in the claim to allow insurers to confirm the ordering of the insurance coverages relative to local 'coordination of benefit' rules. One coverage (and only one) with 'focal=true' is to be used in the adjudication of this claim. Coverages appearing before the focal Coverage in the list, and where 'subrogation=false', should provide a reference to the ClaimResponse containing the adjudication results of the prior claim.
    /// </summary>
    size_t _insurance_count;
    ClaimResponseInsurance** _insurance;
    /// <summary>
    /// If the request contains errors then an error element should be provided and no adjudication related sections (item, addItem, or payment) should be present.
    /// </summary>
    size_t _error_count;
    ClaimResponseError** _error;
  };
};