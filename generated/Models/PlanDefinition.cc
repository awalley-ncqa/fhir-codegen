// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// Indicates what should be done and within what timeframe.
  /// </summary>
  struct PlanDefinitionGoalTarget {
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
    /// The parameter whose value is to be tracked, e.g. body weight, blood pressure, or hemoglobin A1c level.
    /// </summary>
    CodeableConcept* _measure;
    /// <summary>
    /// The target value of the measure to be achieved to signify fulfillment of the goal, e.g. 150 pounds or 7.0%. Either the high or low or both values of the range can be specified. When a low value is missing, it indicates that the goal is achieved at any value at or below the high value. Similarly, if the high value is missing, it indicates that the goal is achieved at any value at or above the low value.
    /// </summary>
    Quantity* _detailQuantity;
    /// <summary>
    /// The target value of the measure to be achieved to signify fulfillment of the goal, e.g. 150 pounds or 7.0%. Either the high or low or both values of the range can be specified. When a low value is missing, it indicates that the goal is achieved at any value at or below the high value. Similarly, if the high value is missing, it indicates that the goal is achieved at any value at or above the low value.
    /// </summary>
    Range* _detailRange;
    /// <summary>
    /// The target value of the measure to be achieved to signify fulfillment of the goal, e.g. 150 pounds or 7.0%. Either the high or low or both values of the range can be specified. When a low value is missing, it indicates that the goal is achieved at any value at or below the high value. Similarly, if the high value is missing, it indicates that the goal is achieved at any value at or above the low value.
    /// </summary>
    CodeableConcept* _detailCodeableConcept;
    /// <summary>
    /// Indicates the timeframe after the start of the goal in which the goal should be met.
    /// </summary>
    Duration* _due;
  };
  /// <summary>
  /// Goals that describe what the activities within the plan are intended to achieve. For example, weight loss, restoring an activity of daily living, obtaining herd immunity via immunization, meeting a process improvement objective, etc.
  /// </summary>
  struct PlanDefinitionGoal {
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
    /// Indicates a category the goal falls within.
    /// </summary>
    CodeableConcept* _category;
    /// <summary>
    /// If no code is available, use CodeableConcept.text.
    /// </summary>
    CodeableConcept* _description;
    /// <summary>
    /// Identifies the expected level of importance associated with reaching/sustaining the defined goal.
    /// </summary>
    CodeableConcept* _priority;
    /// <summary>
    /// The event after which the goal should begin being pursued.
    /// </summary>
    CodeableConcept* _start;
    /// <summary>
    /// Identifies problems, conditions, issues, or concerns the goal is intended to address.
    /// </summary>
    size_t _addresses_count;
    CodeableConcept** _addresses;
    /// <summary>
    /// Didactic or other informational resources associated with the goal that provide further supporting information about the goal. Information resources can include inline text commentary and links to web resources.
    /// </summary>
    size_t _documentation_count;
    RelatedArtifact** _documentation;
    /// <summary>
    /// Indicates what should be done and within what timeframe.
    /// </summary>
    size_t _target_count;
    PlanDefinitionGoalTarget** _target;
  };
  /// <summary>
  /// When multiple conditions of the same kind are present, the effects are combined using AND semantics, so the overall condition is true only if all the conditions are true.
  /// </summary>
  struct PlanDefinitionActionCondition {
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
    /// Applicability criteria are used to determine immediate applicability when a plan definition is applied to a given context. Start and stop criteria are carried through application and used to describe enter/exit criteria for an action.
    /// </summary>
    NullableString8* _kind;
    /// <summary>
    /// The expression may be inlined or may be a reference to a named expression within a logic library referenced by the library element.
    /// </summary>
    Expression* _expression;
  };
  /// <summary>
  /// When an action depends on multiple actions, the meaning is that all actions are dependencies, rather than that any of the actions are a dependency.
  /// </summary>
  struct PlanDefinitionActionRelatedAction {
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
    /// The element id of the related action.
    /// </summary>
    NullableString8* _actionId;
    /// <summary>
    /// The relationship of this action to the related action.
    /// </summary>
    NullableString8* _relationship;
    /// <summary>
    /// A duration or range of durations to apply to the relationship. For example, 30-60 minutes before.
    /// </summary>
    Duration* _offsetDuration;
    /// <summary>
    /// A duration or range of durations to apply to the relationship. For example, 30-60 minutes before.
    /// </summary>
    Range* _offsetRange;
  };
  /// <summary>
  /// Indicates who should participate in performing the action described.
  /// </summary>
  struct PlanDefinitionActionParticipant {
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
    /// The type of participant in the action.
    /// </summary>
    NullableString8* _type;
    /// <summary>
    /// The role the participant should play in performing the described action.
    /// </summary>
    CodeableConcept* _role;
  };
  /// <summary>
  /// Dynamic values are applied in the order in which they are defined in the PlanDefinition resource. Note that when dynamic values are also specified by a referenced ActivityDefinition, the dynamicValues from the ActivityDefinition are applied first, followed by the dynamicValues specified here. In addition, if both a transform and dynamic values are specific, the dynamic values are applied to the result of the transform.
  /// </summary>
  struct PlanDefinitionActionDynamicValue {
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
    /// To specify the path to the current action being realized, the %action environment variable is available in this path. For example, to specify the description element of the target action, the path would be %action.description. The path attribute contains a [Simple FHIRPath Subset](fhirpath.html#simple) that allows path traversal, but not calculation.
    /// </summary>
    string* _path;
    /// <summary>
    /// The expression may be inlined or may be a reference to a named expression within a logic library referenced by the library element.
    /// </summary>
    Expression* _expression;
  };
  /// <summary>
  /// Note that there is overlap between many of the elements defined here and the ActivityDefinition resource. When an ActivityDefinition is referenced (using the definition element), the overlapping elements in the plan override the content of the referenced ActivityDefinition unless otherwise documented in the specific elements. See the PlanDefinition resource for more detailed information.
  /// </summary>
  struct PlanDefinitionAction {
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
    /// A user-visible prefix for the action.
    /// </summary>
    string* _prefix;
    /// <summary>
    /// The title of the action displayed to a user.
    /// </summary>
    string* _title;
    /// <summary>
    /// A brief description of the action used to provide a summary to display to the user.
    /// </summary>
    string* _description;
    /// <summary>
    /// A text equivalent of the action to be performed. This provides a human-interpretable description of the action when the definition is consumed by a system that might not be capable of interpreting it dynamically.
    /// </summary>
    string* _textEquivalent;
    /// <summary>
    /// Indicates how quickly the action should be addressed with respect to other actions.
    /// </summary>
    NullableString8* _priority;
    /// <summary>
    /// A code that provides meaning for the action or action group. For example, a section may have a LOINC code for the section of a documentation template.
    /// </summary>
    size_t _code_count;
    CodeableConcept** _code;
    /// <summary>
    /// This is different than the clinical evidence documentation, it's an actual business description of the reason for performing the action.
    /// </summary>
    size_t _reason_count;
    CodeableConcept** _reason;
    /// <summary>
    /// Didactic or other informational resources associated with the action that can be provided to the CDS recipient. Information resources can include inline text commentary and links to web resources.
    /// </summary>
    size_t _documentation_count;
    RelatedArtifact** _documentation;
    /// <summary>
    /// Identifies goals that this action supports. The reference must be to a goal element defined within this plan definition.
    /// </summary>
    size_t _goalId_count;
    NullableString8** _goalId;
    /// <summary>
    /// The subject of an action overrides the subject at a parent action or on the root of the PlanDefinition if specified.
    /// In addition, because the subject needs to be resolved during realization, use of subjects in actions (or in the ActivityDefinition referenced by the action) resolves based on the set of subjects supplied in context and by type (i.e. the patient subject would resolve to a resource of type Patient).
    /// </summary>
    CodeableConcept* _subjectCodeableConcept;
    /// <summary>
    /// The subject of an action overrides the subject at a parent action or on the root of the PlanDefinition if specified.
    /// In addition, because the subject needs to be resolved during realization, use of subjects in actions (or in the ActivityDefinition referenced by the action) resolves based on the set of subjects supplied in context and by type (i.e. the patient subject would resolve to a resource of type Patient).
    /// </summary>
    Reference* _subjectReference;
    /// <summary>
    /// A description of when the action should be triggered.
    /// </summary>
    size_t _trigger_count;
    TriggerDefinition** _trigger;
    /// <summary>
    /// When multiple conditions of the same kind are present, the effects are combined using AND semantics, so the overall condition is true only if all the conditions are true.
    /// </summary>
    size_t _condition_count;
    PlanDefinitionActionCondition** _condition;
    /// <summary>
    /// Defines input data requirements for the action.
    /// </summary>
    size_t _input_count;
    DataRequirement** _input;
    /// <summary>
    /// Defines the outputs of the action, if any.
    /// </summary>
    size_t _output_count;
    DataRequirement** _output;
    /// <summary>
    /// When an action depends on multiple actions, the meaning is that all actions are dependencies, rather than that any of the actions are a dependency.
    /// </summary>
    size_t _relatedAction_count;
    PlanDefinitionActionRelatedAction** _relatedAction;
    /// <summary>
    /// An optional value describing when the action should be performed.
    /// </summary>
    ISO8601_Time* _timingDateTime;
    /// <summary>
    /// An optional value describing when the action should be performed.
    /// </summary>
    Age* _timingAge;
    /// <summary>
    /// An optional value describing when the action should be performed.
    /// </summary>
    Period* _timingPeriod;
    /// <summary>
    /// An optional value describing when the action should be performed.
    /// </summary>
    Duration* _timingDuration;
    /// <summary>
    /// An optional value describing when the action should be performed.
    /// </summary>
    Range* _timingRange;
    /// <summary>
    /// An optional value describing when the action should be performed.
    /// </summary>
    Timing* _timingTiming;
    /// <summary>
    /// Indicates who should participate in performing the action described.
    /// </summary>
    size_t _participant_count;
    PlanDefinitionActionParticipant** _participant;
    /// <summary>
    /// The type of action to perform (create, update, remove).
    /// </summary>
    CodeableConcept* _type;
    /// <summary>
    /// Defines the grouping behavior for the action and its children.
    /// </summary>
    NullableString8* _groupingBehavior;
    /// <summary>
    /// Defines the selection behavior for the action and its children.
    /// </summary>
    NullableString8* _selectionBehavior;
    /// <summary>
    /// Defines the required behavior for the action.
    /// </summary>
    NullableString8* _requiredBehavior;
    /// <summary>
    /// Defines whether the action should usually be preselected.
    /// </summary>
    NullableString8* _precheckBehavior;
    /// <summary>
    /// Defines whether the action can be selected multiple times.
    /// </summary>
    NullableString8* _cardinalityBehavior;
    /// <summary>
    /// Note that the definition is optional, and if no definition is specified, a dynamicValue with a root ($this) path can be used to define the entire resource dynamically.
    /// </summary>
    NullableString8* _definitionCanonical;
    /// <summary>
    /// Note that the definition is optional, and if no definition is specified, a dynamicValue with a root ($this) path can be used to define the entire resource dynamically.
    /// </summary>
    NullableString8* _definitionUri;
    /// <summary>
    /// Note that when a referenced ActivityDefinition also defines a transform, the transform specified here generally takes precedence. In addition, if both a transform and dynamic values are specific, the dynamic values are applied to the result of the transform.
    /// </summary>
    NullableString8* _transform;
    /// <summary>
    /// Dynamic values are applied in the order in which they are defined in the PlanDefinition resource. Note that when dynamic values are also specified by a referenced ActivityDefinition, the dynamicValues from the ActivityDefinition are applied first, followed by the dynamicValues specified here. In addition, if both a transform and dynamic values are specific, the dynamic values are applied to the result of the transform.
    /// </summary>
    size_t _dynamicValue_count;
    PlanDefinitionActionDynamicValue** _dynamicValue;
    /// <summary>
    /// Sub actions that are contained within the action. The behavior of this action determines the functionality of the sub-actions. For example, a selection behavior of at-most-one indicates that of the sub-actions, at most one may be chosen as part of realizing the action definition.
    /// </summary>
    size_t _actionField_count;
    PlanDefinitionAction** _actionField;
  };
  /// <summary>
  /// This resource allows for the definition of various types of plans as a sharable, consumable, and executable artifact. The resource is general enough to support the description of a broad range of clinical artifacts such as clinical decision support rules, order sets and protocols.
  /// </summary>
  struct PlanDefinition {
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
    /// Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this plan definition outside of FHIR, where it is not possible to use the logical URI.
    /// </summary>
    size_t _identifier_count;
    Identifier** _identifier;
    /// <summary>
    /// There may be different plan definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the plan definition with the format [url]|[version].
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
    /// An explanatory or alternate title for the plan definition giving additional information about its content.
    /// </summary>
    string* _subtitle;
    /// <summary>
    /// A high-level category for the plan definition that distinguishes the kinds of systems that would be interested in the plan definition.
    /// </summary>
    CodeableConcept* _type;
    /// <summary>
    /// Allows filtering of plan definitions that are appropriate for use versus not.
    /// </summary>
    NullableString8* _status;
    /// <summary>
    /// Allows filtering of plan definitions that are appropriate for use versus not.
    /// </summary>
    NullableBoolean* _experimental;
    /// <summary>
    /// A code or group definition that describes the intended subject of the plan definition.
    /// </summary>
    CodeableConcept* _subjectCodeableConcept;
    /// <summary>
    /// A code or group definition that describes the intended subject of the plan definition.
    /// </summary>
    Reference* _subjectReference;
    /// <summary>
    /// Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the plan definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.
    /// </summary>
    ISO8601_Time* _date;
    /// <summary>
    /// Usually an organization but may be an individual. The publisher (or steward) of the plan definition is the organization or individual primarily responsible for the maintenance and upkeep of the plan definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the plan definition. This item SHOULD be populated unless the information is available from context.
    /// </summary>
    string* _publisher;
    /// <summary>
    /// May be a web site, an email address, a telephone number, etc.
    /// </summary>
    size_t _contact_count;
    ContactDetail** _contact;
    /// <summary>
    /// This description can be used to capture details such as why the plan definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the plan definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the plan definition is presumed to be the predominant language in the place the plan definition was created).
    /// </summary>
    NullableString8* _description;
    /// <summary>
    /// When multiple useContexts are specified, there is no expectation that all or any of the contexts apply.
    /// </summary>
    size_t _useContext_count;
    UsageContext** _useContext;
    /// <summary>
    /// It may be possible for the plan definition to be used in jurisdictions other than those for which it was originally designed or intended.
    /// </summary>
    size_t _jurisdiction_count;
    CodeableConcept** _jurisdiction;
    /// <summary>
    /// This element does not describe the usage of the plan definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this plan definition.
    /// </summary>
    NullableString8* _purpose;
    /// <summary>
    /// A detailed description of how the plan definition is used from a clinical perspective.
    /// </summary>
    string* _usage;
    /// <summary>
    /// A copyright statement relating to the plan definition and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the plan definition.
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
    /// The effective period for a plan definition  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.
    /// </summary>
    Period* _effectivePeriod;
    /// <summary>
    /// Descriptive topics related to the content of the plan definition. Topics provide a high-level categorization of the definition that can be useful for filtering and searching.
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
    /// A reference to a Library resource containing any formal logic used by the plan definition.
    /// </summary>
    size_t _library_count;
    NullableString8** _library;
    /// <summary>
    /// Goals that describe what the activities within the plan are intended to achieve. For example, weight loss, restoring an activity of daily living, obtaining herd immunity via immunization, meeting a process improvement objective, etc.
    /// </summary>
    size_t _goal_count;
    PlanDefinitionGoal** _goal;
    /// <summary>
    /// Note that there is overlap between many of the elements defined here and the ActivityDefinition resource. When an ActivityDefinition is referenced (using the definition element), the overlapping elements in the plan override the content of the referenced ActivityDefinition unless otherwise documented in the specific elements. See the PlanDefinition resource for more detailed information.
    /// </summary>
    size_t _action_count;
    PlanDefinitionAction** _action;
  };
};