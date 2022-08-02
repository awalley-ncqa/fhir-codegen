// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Indicates why the state of the subject changed.
  /// </summary>
  public static class StateChangeReasonCodes
  {
    /// <summary>
    /// adverse event.
    /// </summary>
    public static readonly Coding AdverseEvent = new Coding
    {
      Code = "adverseEvent",
      Display = "adverse event",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// The study is now complete.
    /// </summary>
    public static readonly Coding Complete = new Coding
    {
      Code = "complete",
      Display = "Complete",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// death (adverse event).
    /// </summary>
    public static readonly Coding DeathAdverseEvent = new Coding
    {
      Code = "death",
      Display = "death (adverse event)",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// Relapse of disease.
    /// </summary>
    public static readonly Coding DiseaseRelapse = new Coding
    {
      Code = "diseaseRelapse",
      Display = "Disease Relapse",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// eligible but unwilling or unable to participate.
    /// </summary>
    public static readonly Coding EligibleButUnwillingOrUnableToParticipate = new Coding
    {
      Code = "eligibleButNo",
      Display = "eligible but unwilling or unable to participate",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// enrolled or registered.
    /// </summary>
    public static readonly Coding EnrolledOrRegistered = new Coding
    {
      Code = "enrolled",
      Display = "enrolled or registered",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// exclusion.
    /// </summary>
    public static readonly Coding Exclusion = new Coding
    {
      Code = "exclusion",
      Display = "exclusion",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// Subject failed randomization.
    /// </summary>
    public static readonly Coding FailedRandomization = new Coding
    {
      Code = "failedRandomization",
      Display = "Failed Randomization",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// follow-up complete.
    /// </summary>
    public static readonly Coding FollowUpComplete = new Coding
    {
      Code = "followUpComplete",
      Display = "follow-up complete",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// inclusion.
    /// </summary>
    public static readonly Coding Inclusion = new Coding
    {
      Code = "inclusion",
      Display = "inclusion",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// Informed consent signed.
    /// </summary>
    public static readonly Coding InformedConsentSigned = new Coding
    {
      Code = "informedConsentSigned",
      Display = "Informed consent signed",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// intervention or observation complete.
    /// </summary>
    public static readonly Coding InterventionOrObservationComplete = new Coding
    {
      Code = "intOrObsComplete",
      Display = "intervention or observation complete",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// The study activities were not efficient in dealing with the underlying issue.
    /// </summary>
    public static readonly Coding LackOfEfficacy = new Coding
    {
      Code = "lackOfEfficacy",
      Display = "Lack Of Efficacy",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// The subject can no longer be followed up.
    /// </summary>
    public static readonly Coding LostToFollowUp = new Coding
    {
      Code = "lostToFollowUp",
      Display = "Lost To Follow Up",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// non-compliance.
    /// </summary>
    public static readonly Coding NonCompliance = new Coding
    {
      Code = "nonCompliance",
      Display = "non-compliance",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// did not meet eligibility criteria.
    /// </summary>
    public static readonly Coding DidNotMeetEligibilityCriteria = new Coding
    {
      Code = "notEligible",
      Display = "did not meet eligibility criteria",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// A physician has decided the subject should no longer continue on the study.
    /// </summary>
    public static readonly Coding PhysicianDecision = new Coding
    {
      Code = "physicianDecision",
      Display = "Physician Decision",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// Subject is now pregnant and no longer meets the inclusion criteria.
    /// </summary>
    public static readonly Coding Pregnancy = new Coding
    {
      Code = "pregnancy",
      Display = "Pregnancy",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// pre-registered or slot reserved.
    /// </summary>
    public static readonly Coding PreRegisteredOrSlotReserved = new Coding
    {
      Code = "preReg",
      Display = "pre-registered or slot reserved",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// The subject has a disease that has progressed to far to allow them to continue in the study.
    /// </summary>
    public static readonly Coding ProgressiveDisease = new Coding
    {
      Code = "progressiveDisease",
      Display = "Progressive Disease",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// There has been a protocol deviation that cannot be corrected or compensated for.
    /// </summary>
    public static readonly Coding ProtocolDeviation = new Coding
    {
      Code = "protocolDeviation",
      Display = "Protocol Deviation",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// The subject has recovered and no longer meets the inclusion criteria.
    /// </summary>
    public static readonly Coding Recovery = new Coding
    {
      Code = "recovery",
      Display = "Recovery",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// refuse consent.
    /// </summary>
    public static readonly Coding RefuseConsent = new Coding
    {
      Code = "refuseConsent",
      Display = "refuse consent",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// screen failure.
    /// </summary>
    public static readonly Coding ScreenFailure = new Coding
    {
      Code = "screenFailure",
      Display = "screen failure",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// The site where the subject was being treated is no longer in the study.
    /// </summary>
    public static readonly Coding SiteTerminated = new Coding
    {
      Code = "siteTerminated",
      Display = "Site Terminated",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// study permanently closed to accrual.
    /// </summary>
    public static readonly Coding StudyPermanentlyClosedToAccrual = new Coding
    {
      Code = "studyClosed",
      Display = "study permanently closed to accrual",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// study terminated.
    /// </summary>
    public static readonly Coding StudyTerminated = new Coding
    {
      Code = "studyTerminated",
      Display = "study terminated",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// subject refusal.
    /// </summary>
    public static readonly Coding SubjectRefusal = new Coding
    {
      Code = "subjectRefusal",
      Display = "subject refusal",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// The subject cannot continue on the study due to technical issues.
    /// </summary>
    public static readonly Coding TechnicalProblems = new Coding
    {
      Code = "technicalProblems",
      Display = "Technical Problems",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// unwilling or unable to participate.
    /// </summary>
    public static readonly Coding UnwillingOrUnableToParticipate = new Coding
    {
      Code = "unwillingOrUnable",
      Display = "unwilling or unable to participate",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };
    /// <summary>
    /// withdrawn consent.
    /// </summary>
    public static readonly Coding WithdrawnConsent = new Coding
    {
      Code = "withdrawnConsent",
      Display = "withdrawn consent",
      System = "http://terminology.hl7.org/CodeSystem/state-change-reason"
    };

    /// <summary>
    /// Literal for code: AdverseEvent
    /// </summary>
    public const string LiteralAdverseEvent = "adverseEvent";

    /// <summary>
    /// Literal for code: StateChangeReasonAdverseEvent
    /// </summary>
    public const string LiteralStateChangeReasonAdverseEvent = "http://terminology.hl7.org/CodeSystem/state-change-reason#adverseEvent";

    /// <summary>
    /// Literal for code: Complete
    /// </summary>
    public const string LiteralComplete = "complete";

    /// <summary>
    /// Literal for code: StateChangeReasonComplete
    /// </summary>
    public const string LiteralStateChangeReasonComplete = "http://terminology.hl7.org/CodeSystem/state-change-reason#complete";

    /// <summary>
    /// Literal for code: DeathAdverseEvent
    /// </summary>
    public const string LiteralDeathAdverseEvent = "death";

    /// <summary>
    /// Literal for code: StateChangeReasonDeathAdverseEvent
    /// </summary>
    public const string LiteralStateChangeReasonDeathAdverseEvent = "http://terminology.hl7.org/CodeSystem/state-change-reason#death";

    /// <summary>
    /// Literal for code: DiseaseRelapse
    /// </summary>
    public const string LiteralDiseaseRelapse = "diseaseRelapse";

    /// <summary>
    /// Literal for code: StateChangeReasonDiseaseRelapse
    /// </summary>
    public const string LiteralStateChangeReasonDiseaseRelapse = "http://terminology.hl7.org/CodeSystem/state-change-reason#diseaseRelapse";

    /// <summary>
    /// Literal for code: EligibleButUnwillingOrUnableToParticipate
    /// </summary>
    public const string LiteralEligibleButUnwillingOrUnableToParticipate = "eligibleButNo";

    /// <summary>
    /// Literal for code: StateChangeReasonEligibleButUnwillingOrUnableToParticipate
    /// </summary>
    public const string LiteralStateChangeReasonEligibleButUnwillingOrUnableToParticipate = "http://terminology.hl7.org/CodeSystem/state-change-reason#eligibleButNo";

    /// <summary>
    /// Literal for code: EnrolledOrRegistered
    /// </summary>
    public const string LiteralEnrolledOrRegistered = "enrolled";

    /// <summary>
    /// Literal for code: StateChangeReasonEnrolledOrRegistered
    /// </summary>
    public const string LiteralStateChangeReasonEnrolledOrRegistered = "http://terminology.hl7.org/CodeSystem/state-change-reason#enrolled";

    /// <summary>
    /// Literal for code: Exclusion
    /// </summary>
    public const string LiteralExclusion = "exclusion";

    /// <summary>
    /// Literal for code: StateChangeReasonExclusion
    /// </summary>
    public const string LiteralStateChangeReasonExclusion = "http://terminology.hl7.org/CodeSystem/state-change-reason#exclusion";

    /// <summary>
    /// Literal for code: FailedRandomization
    /// </summary>
    public const string LiteralFailedRandomization = "failedRandomization";

    /// <summary>
    /// Literal for code: StateChangeReasonFailedRandomization
    /// </summary>
    public const string LiteralStateChangeReasonFailedRandomization = "http://terminology.hl7.org/CodeSystem/state-change-reason#failedRandomization";

    /// <summary>
    /// Literal for code: FollowUpComplete
    /// </summary>
    public const string LiteralFollowUpComplete = "followUpComplete";

    /// <summary>
    /// Literal for code: StateChangeReasonFollowUpComplete
    /// </summary>
    public const string LiteralStateChangeReasonFollowUpComplete = "http://terminology.hl7.org/CodeSystem/state-change-reason#followUpComplete";

    /// <summary>
    /// Literal for code: Inclusion
    /// </summary>
    public const string LiteralInclusion = "inclusion";

    /// <summary>
    /// Literal for code: StateChangeReasonInclusion
    /// </summary>
    public const string LiteralStateChangeReasonInclusion = "http://terminology.hl7.org/CodeSystem/state-change-reason#inclusion";

    /// <summary>
    /// Literal for code: InformedConsentSigned
    /// </summary>
    public const string LiteralInformedConsentSigned = "informedConsentSigned";

    /// <summary>
    /// Literal for code: StateChangeReasonInformedConsentSigned
    /// </summary>
    public const string LiteralStateChangeReasonInformedConsentSigned = "http://terminology.hl7.org/CodeSystem/state-change-reason#informedConsentSigned";

    /// <summary>
    /// Literal for code: InterventionOrObservationComplete
    /// </summary>
    public const string LiteralInterventionOrObservationComplete = "intOrObsComplete";

    /// <summary>
    /// Literal for code: StateChangeReasonInterventionOrObservationComplete
    /// </summary>
    public const string LiteralStateChangeReasonInterventionOrObservationComplete = "http://terminology.hl7.org/CodeSystem/state-change-reason#intOrObsComplete";

    /// <summary>
    /// Literal for code: LackOfEfficacy
    /// </summary>
    public const string LiteralLackOfEfficacy = "lackOfEfficacy";

    /// <summary>
    /// Literal for code: StateChangeReasonLackOfEfficacy
    /// </summary>
    public const string LiteralStateChangeReasonLackOfEfficacy = "http://terminology.hl7.org/CodeSystem/state-change-reason#lackOfEfficacy";

    /// <summary>
    /// Literal for code: LostToFollowUp
    /// </summary>
    public const string LiteralLostToFollowUp = "lostToFollowUp";

    /// <summary>
    /// Literal for code: StateChangeReasonLostToFollowUp
    /// </summary>
    public const string LiteralStateChangeReasonLostToFollowUp = "http://terminology.hl7.org/CodeSystem/state-change-reason#lostToFollowUp";

    /// <summary>
    /// Literal for code: NonCompliance
    /// </summary>
    public const string LiteralNonCompliance = "nonCompliance";

    /// <summary>
    /// Literal for code: StateChangeReasonNonCompliance
    /// </summary>
    public const string LiteralStateChangeReasonNonCompliance = "http://terminology.hl7.org/CodeSystem/state-change-reason#nonCompliance";

    /// <summary>
    /// Literal for code: DidNotMeetEligibilityCriteria
    /// </summary>
    public const string LiteralDidNotMeetEligibilityCriteria = "notEligible";

    /// <summary>
    /// Literal for code: StateChangeReasonDidNotMeetEligibilityCriteria
    /// </summary>
    public const string LiteralStateChangeReasonDidNotMeetEligibilityCriteria = "http://terminology.hl7.org/CodeSystem/state-change-reason#notEligible";

    /// <summary>
    /// Literal for code: PhysicianDecision
    /// </summary>
    public const string LiteralPhysicianDecision = "physicianDecision";

    /// <summary>
    /// Literal for code: StateChangeReasonPhysicianDecision
    /// </summary>
    public const string LiteralStateChangeReasonPhysicianDecision = "http://terminology.hl7.org/CodeSystem/state-change-reason#physicianDecision";

    /// <summary>
    /// Literal for code: Pregnancy
    /// </summary>
    public const string LiteralPregnancy = "pregnancy";

    /// <summary>
    /// Literal for code: StateChangeReasonPregnancy
    /// </summary>
    public const string LiteralStateChangeReasonPregnancy = "http://terminology.hl7.org/CodeSystem/state-change-reason#pregnancy";

    /// <summary>
    /// Literal for code: PreRegisteredOrSlotReserved
    /// </summary>
    public const string LiteralPreRegisteredOrSlotReserved = "preReg";

    /// <summary>
    /// Literal for code: StateChangeReasonPreRegisteredOrSlotReserved
    /// </summary>
    public const string LiteralStateChangeReasonPreRegisteredOrSlotReserved = "http://terminology.hl7.org/CodeSystem/state-change-reason#preReg";

    /// <summary>
    /// Literal for code: ProgressiveDisease
    /// </summary>
    public const string LiteralProgressiveDisease = "progressiveDisease";

    /// <summary>
    /// Literal for code: StateChangeReasonProgressiveDisease
    /// </summary>
    public const string LiteralStateChangeReasonProgressiveDisease = "http://terminology.hl7.org/CodeSystem/state-change-reason#progressiveDisease";

    /// <summary>
    /// Literal for code: ProtocolDeviation
    /// </summary>
    public const string LiteralProtocolDeviation = "protocolDeviation";

    /// <summary>
    /// Literal for code: StateChangeReasonProtocolDeviation
    /// </summary>
    public const string LiteralStateChangeReasonProtocolDeviation = "http://terminology.hl7.org/CodeSystem/state-change-reason#protocolDeviation";

    /// <summary>
    /// Literal for code: Recovery
    /// </summary>
    public const string LiteralRecovery = "recovery";

    /// <summary>
    /// Literal for code: StateChangeReasonRecovery
    /// </summary>
    public const string LiteralStateChangeReasonRecovery = "http://terminology.hl7.org/CodeSystem/state-change-reason#recovery";

    /// <summary>
    /// Literal for code: RefuseConsent
    /// </summary>
    public const string LiteralRefuseConsent = "refuseConsent";

    /// <summary>
    /// Literal for code: StateChangeReasonRefuseConsent
    /// </summary>
    public const string LiteralStateChangeReasonRefuseConsent = "http://terminology.hl7.org/CodeSystem/state-change-reason#refuseConsent";

    /// <summary>
    /// Literal for code: ScreenFailure
    /// </summary>
    public const string LiteralScreenFailure = "screenFailure";

    /// <summary>
    /// Literal for code: StateChangeReasonScreenFailure
    /// </summary>
    public const string LiteralStateChangeReasonScreenFailure = "http://terminology.hl7.org/CodeSystem/state-change-reason#screenFailure";

    /// <summary>
    /// Literal for code: SiteTerminated
    /// </summary>
    public const string LiteralSiteTerminated = "siteTerminated";

    /// <summary>
    /// Literal for code: StateChangeReasonSiteTerminated
    /// </summary>
    public const string LiteralStateChangeReasonSiteTerminated = "http://terminology.hl7.org/CodeSystem/state-change-reason#siteTerminated";

    /// <summary>
    /// Literal for code: StudyPermanentlyClosedToAccrual
    /// </summary>
    public const string LiteralStudyPermanentlyClosedToAccrual = "studyClosed";

    /// <summary>
    /// Literal for code: StateChangeReasonStudyPermanentlyClosedToAccrual
    /// </summary>
    public const string LiteralStateChangeReasonStudyPermanentlyClosedToAccrual = "http://terminology.hl7.org/CodeSystem/state-change-reason#studyClosed";

    /// <summary>
    /// Literal for code: StudyTerminated
    /// </summary>
    public const string LiteralStudyTerminated = "studyTerminated";

    /// <summary>
    /// Literal for code: StateChangeReasonStudyTerminated
    /// </summary>
    public const string LiteralStateChangeReasonStudyTerminated = "http://terminology.hl7.org/CodeSystem/state-change-reason#studyTerminated";

    /// <summary>
    /// Literal for code: SubjectRefusal
    /// </summary>
    public const string LiteralSubjectRefusal = "subjectRefusal";

    /// <summary>
    /// Literal for code: StateChangeReasonSubjectRefusal
    /// </summary>
    public const string LiteralStateChangeReasonSubjectRefusal = "http://terminology.hl7.org/CodeSystem/state-change-reason#subjectRefusal";

    /// <summary>
    /// Literal for code: TechnicalProblems
    /// </summary>
    public const string LiteralTechnicalProblems = "technicalProblems";

    /// <summary>
    /// Literal for code: StateChangeReasonTechnicalProblems
    /// </summary>
    public const string LiteralStateChangeReasonTechnicalProblems = "http://terminology.hl7.org/CodeSystem/state-change-reason#technicalProblems";

    /// <summary>
    /// Literal for code: UnwillingOrUnableToParticipate
    /// </summary>
    public const string LiteralUnwillingOrUnableToParticipate = "unwillingOrUnable";

    /// <summary>
    /// Literal for code: StateChangeReasonUnwillingOrUnableToParticipate
    /// </summary>
    public const string LiteralStateChangeReasonUnwillingOrUnableToParticipate = "http://terminology.hl7.org/CodeSystem/state-change-reason#unwillingOrUnable";

    /// <summary>
    /// Literal for code: WithdrawnConsent
    /// </summary>
    public const string LiteralWithdrawnConsent = "withdrawnConsent";

    /// <summary>
    /// Literal for code: StateChangeReasonWithdrawnConsent
    /// </summary>
    public const string LiteralStateChangeReasonWithdrawnConsent = "http://terminology.hl7.org/CodeSystem/state-change-reason#withdrawnConsent";

    /// <summary>
    /// Dictionary for looking up StateChangeReason Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "adverseEvent", AdverseEvent }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#adverseEvent", AdverseEvent }, 
      { "complete", Complete }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#complete", Complete }, 
      { "death", DeathAdverseEvent }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#death", DeathAdverseEvent }, 
      { "diseaseRelapse", DiseaseRelapse }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#diseaseRelapse", DiseaseRelapse }, 
      { "eligibleButNo", EligibleButUnwillingOrUnableToParticipate }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#eligibleButNo", EligibleButUnwillingOrUnableToParticipate }, 
      { "enrolled", EnrolledOrRegistered }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#enrolled", EnrolledOrRegistered }, 
      { "exclusion", Exclusion }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#exclusion", Exclusion }, 
      { "failedRandomization", FailedRandomization }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#failedRandomization", FailedRandomization }, 
      { "followUpComplete", FollowUpComplete }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#followUpComplete", FollowUpComplete }, 
      { "inclusion", Inclusion }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#inclusion", Inclusion }, 
      { "informedConsentSigned", InformedConsentSigned }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#informedConsentSigned", InformedConsentSigned }, 
      { "intOrObsComplete", InterventionOrObservationComplete }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#intOrObsComplete", InterventionOrObservationComplete }, 
      { "lackOfEfficacy", LackOfEfficacy }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#lackOfEfficacy", LackOfEfficacy }, 
      { "lostToFollowUp", LostToFollowUp }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#lostToFollowUp", LostToFollowUp }, 
      { "nonCompliance", NonCompliance }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#nonCompliance", NonCompliance }, 
      { "notEligible", DidNotMeetEligibilityCriteria }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#notEligible", DidNotMeetEligibilityCriteria }, 
      { "physicianDecision", PhysicianDecision }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#physicianDecision", PhysicianDecision }, 
      { "pregnancy", Pregnancy }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#pregnancy", Pregnancy }, 
      { "preReg", PreRegisteredOrSlotReserved }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#preReg", PreRegisteredOrSlotReserved }, 
      { "progressiveDisease", ProgressiveDisease }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#progressiveDisease", ProgressiveDisease }, 
      { "protocolDeviation", ProtocolDeviation }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#protocolDeviation", ProtocolDeviation }, 
      { "recovery", Recovery }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#recovery", Recovery }, 
      { "refuseConsent", RefuseConsent }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#refuseConsent", RefuseConsent }, 
      { "screenFailure", ScreenFailure }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#screenFailure", ScreenFailure }, 
      { "siteTerminated", SiteTerminated }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#siteTerminated", SiteTerminated }, 
      { "studyClosed", StudyPermanentlyClosedToAccrual }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#studyClosed", StudyPermanentlyClosedToAccrual }, 
      { "studyTerminated", StudyTerminated }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#studyTerminated", StudyTerminated }, 
      { "subjectRefusal", SubjectRefusal }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#subjectRefusal", SubjectRefusal }, 
      { "technicalProblems", TechnicalProblems }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#technicalProblems", TechnicalProblems }, 
      { "unwillingOrUnable", UnwillingOrUnableToParticipate }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#unwillingOrUnable", UnwillingOrUnableToParticipate }, 
      { "withdrawnConsent", WithdrawnConsent }, 
      { "http://terminology.hl7.org/CodeSystem/state-change-reason#withdrawnConsent", WithdrawnConsent }, 
    };
  };
}