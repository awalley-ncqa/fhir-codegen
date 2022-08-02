// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// An example value set of Codified order entry details concepts.  These concepts only make sense in the context of what is being ordered.  This example is for a patient ventilation order
  /// </summary>
  public static class ServicerequestOrderdetailCodes
  {
    /// <summary>
    /// Patient triggered inspiratory assistance (procedure)
    /// </summary>
    public static readonly Coding PatientTriggeredInspiratoryAssistanceProcedure = new Coding
    {
      Code = "243144002",
      Display = "Patient triggered inspiratory assistance (procedure)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Assisted controlled mandatory ventilation (procedure)
    /// </summary>
    public static readonly Coding AssistedControlledMandatoryVentilationProcedure = new Coding
    {
      Code = "243150007",
      Display = "Assisted controlled mandatory ventilation (procedure)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Pressure controlled ventilation (procedure)
    /// </summary>
    public static readonly Coding PressureControlledVentilationProcedure = new Coding
    {
      Code = "286812008",
      Display = "Pressure controlled ventilation (procedure)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Continuous positive airway pressure ventilation treatment (regime/therapy)
    /// </summary>
    public static readonly Coding ContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy = new Coding
    {
      Code = "47545007",
      Display = "Continuous positive airway pressure ventilation treatment (regime/therapy)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Synchronized intermittent mandatory ventilation (procedure)
    /// </summary>
    public static readonly Coding SynchronizedIntermittentMandatoryVentilationProcedure = new Coding
    {
      Code = "59427005",
      Display = "Synchronized intermittent mandatory ventilation (procedure)",
      System = "http://snomed.info/sct"
    };

    /// <summary>
    /// Literal for code: PatientTriggeredInspiratoryAssistanceProcedure
    /// </summary>
    public const string LiteralPatientTriggeredInspiratoryAssistanceProcedure = "243144002";

    /// <summary>
    /// Literal for code: NONEPatientTriggeredInspiratoryAssistanceProcedure
    /// </summary>
    public const string LiteralNONEPatientTriggeredInspiratoryAssistanceProcedure = "http://snomed.info/sct#243144002";

    /// <summary>
    /// Literal for code: AssistedControlledMandatoryVentilationProcedure
    /// </summary>
    public const string LiteralAssistedControlledMandatoryVentilationProcedure = "243150007";

    /// <summary>
    /// Literal for code: NONEAssistedControlledMandatoryVentilationProcedure
    /// </summary>
    public const string LiteralNONEAssistedControlledMandatoryVentilationProcedure = "http://snomed.info/sct#243150007";

    /// <summary>
    /// Literal for code: PressureControlledVentilationProcedure
    /// </summary>
    public const string LiteralPressureControlledVentilationProcedure = "286812008";

    /// <summary>
    /// Literal for code: NONEPressureControlledVentilationProcedure
    /// </summary>
    public const string LiteralNONEPressureControlledVentilationProcedure = "http://snomed.info/sct#286812008";

    /// <summary>
    /// Literal for code: ContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy
    /// </summary>
    public const string LiteralContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy = "47545007";

    /// <summary>
    /// Literal for code: NONEContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy
    /// </summary>
    public const string LiteralNONEContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy = "http://snomed.info/sct#47545007";

    /// <summary>
    /// Literal for code: SynchronizedIntermittentMandatoryVentilationProcedure
    /// </summary>
    public const string LiteralSynchronizedIntermittentMandatoryVentilationProcedure = "59427005";

    /// <summary>
    /// Literal for code: NONESynchronizedIntermittentMandatoryVentilationProcedure
    /// </summary>
    public const string LiteralNONESynchronizedIntermittentMandatoryVentilationProcedure = "http://snomed.info/sct#59427005";

    /// <summary>
    /// Dictionary for looking up ServicerequestOrderdetail Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "243144002", PatientTriggeredInspiratoryAssistanceProcedure }, 
      { "http://snomed.info/sct#243144002", PatientTriggeredInspiratoryAssistanceProcedure }, 
      { "243150007", AssistedControlledMandatoryVentilationProcedure }, 
      { "http://snomed.info/sct#243150007", AssistedControlledMandatoryVentilationProcedure }, 
      { "286812008", PressureControlledVentilationProcedure }, 
      { "http://snomed.info/sct#286812008", PressureControlledVentilationProcedure }, 
      { "47545007", ContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy }, 
      { "http://snomed.info/sct#47545007", ContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy }, 
      { "59427005", SynchronizedIntermittentMandatoryVentilationProcedure }, 
      { "http://snomed.info/sct#59427005", SynchronizedIntermittentMandatoryVentilationProcedure }, 
    };
  };
}