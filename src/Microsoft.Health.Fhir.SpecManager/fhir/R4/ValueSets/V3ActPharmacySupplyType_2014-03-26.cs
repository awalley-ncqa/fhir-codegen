// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  ///  Identifies types of dispensing events
  /// </summary>
  public static class V3ActPharmacySupplyTypeCodes
  {
    /// <summary>
    /// A fill providing sufficient supply for one day
    /// </summary>
    public static readonly Coding DailyFill = new Coding
    {
      Code = "DF",
      Display = "Daily Fill",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A supply action where there is no 'valid' order for the supplied medication.  E.g. Emergency vacation supply, weekend supply (when prescriber is unavailable to provide a renewal prescription)
    /// </summary>
    public static readonly Coding EmergencySupply = new Coding
    {
      Code = "EM",
      Display = "Emergency Supply",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// The initial fill against an order.  (This includes initial fills against refill orders.)
    /// </summary>
    public static readonly Coding FirstFill = new Coding
    {
      Code = "FF",
      Display = "First Fill",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A first fill where the quantity supplied is equal to one full repetition of the ordered amount. (e.g. If the order was 90 tablets, 3 refills, a complete fill would be for the full 90 tablets).
    /// </summary>
    public static readonly Coding FirstFillComplete = new Coding
    {
      Code = "FFC",
      Display = "First Fill - Complete",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A first fill where the quantity supplied is less than one full repetition of the ordered amount. (e.g. If the order was 90 tablets, 3 refills, a partial fill might be for only 30 tablets.)
    /// </summary>
    public static readonly Coding FirstFillPartFill = new Coding
    {
      Code = "FFP",
      Display = "First Fill - Part Fill",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A first fill where the strength supplied is less than the ordered strength. (e.g. 10mg for an order of 50mg where a subsequent fill will dispense 40mg tablets).
    /// </summary>
    public static readonly Coding FirstFillPartialStrength = new Coding
    {
      Code = "FFSS",
      Display = "first fill, partial strength",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A supply action to restock a smaller more local dispensary.
    /// </summary>
    public static readonly Coding FloorStock = new Coding
    {
      Code = "FS",
      Display = "Floor stock",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A supply of a manufacturer sample
    /// </summary>
    public static readonly Coding ManufacturerSample = new Coding
    {
      Code = "MS",
      Display = "Manufacturer Sample",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A fill against an order that has already been filled (or partially filled) at least once.
    /// </summary>
    public static readonly Coding Refill = new Coding
    {
      Code = "RF",
      Display = "Refill",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A refill where the quantity supplied is equal to one full repetition of the ordered amount. (e.g. If the order was 90 tablets, 3 refills, a complete fill would be for the full 90 tablets.)
    /// </summary>
    public static readonly Coding RefillComplete = new Coding
    {
      Code = "RFC",
      Display = "Refill - Complete",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A refill where the quantity supplied is equal to one full repetition of the ordered amount. (e.g. If the order was 90 tablets, 3 refills, a complete fill would be for the full 90 tablets.) and where the strength supplied is less than the ordered strength (e.g. 10mg for an order of 50mg where a subsequent fill will dispense 40mg tablets).
    /// </summary>
    public static readonly Coding RefillCompletePartialStrength = new Coding
    {
      Code = "RFCS",
      Display = "refill complete partial strength",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// The first fill against an order that has already been filled at least once at another facility.
    /// </summary>
    public static readonly Coding RefillFirstFillThisFacility = new Coding
    {
      Code = "RFF",
      Display = "Refill (First fill this facility)",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// The first fill against an order that has already been filled at least once at another facility and where the strength supplied is less than the ordered strength (e.g. 10mg for an order of 50mg where a subsequent fill will dispense 40mg tablets).
    /// </summary>
    public static readonly Coding RefillPartialStrengthFirstFillThisFacility = new Coding
    {
      Code = "RFFS",
      Display = "refill partial strength (first fill this facility)",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A refill where the quantity supplied is less than one full repetition of the ordered amount. (e.g. If the order was 90 tablets, 3 refills, a partial fill might be for only 30 tablets.)
    /// </summary>
    public static readonly Coding RefillPartFill = new Coding
    {
      Code = "RFP",
      Display = "Refill - Part Fill",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A refill where the quantity supplied is less than one full repetition of the ordered amount. (e.g. If the order was 90 tablets, 3 refills, a partial fill might be for only 30 tablets.) and where the strength supplied is less than the ordered strength (e.g. 10mg for an order of 50mg where a subsequent fill will dispense 40mg tablets).
    /// </summary>
    public static readonly Coding RefillPartFillPartialStrength = new Coding
    {
      Code = "RFPS",
      Display = "refill part fill partial strength",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A fill against an order that has already been filled (or partially filled) at least once and where the strength supplied is less than the ordered strength (e.g. 10mg for an order of 50mg where a subsequent fill will dispense 40mg tablets).
    /// </summary>
    public static readonly Coding RefillPartialStrength = new Coding
    {
      Code = "RFS",
      Display = "refill partial strength",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// An emergency supply where the expectation is that a formal order authorizing the supply will be provided at a later date.
    /// </summary>
    public static readonly Coding ScriptOwing = new Coding
    {
      Code = "SO",
      Display = "Script Owing",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A fill where the remainder of a 'complete' fill is provided after a trial fill has been provided.
    /// </summary>
    public static readonly Coding TrialBalance = new Coding
    {
      Code = "TB",
      Display = "Trial Balance",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A fill where the remainder of a 'complete' fill is provided after a trial fill has been provided and where the strength supplied is less than the ordered strength (e.g. 10mg for an order of 50mg where a subsequent fill will dispense 40mg tablets).
    /// </summary>
    public static readonly Coding TrialBalancePartialStrength = new Coding
    {
      Code = "TBS",
      Display = "trial balance partial strength",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A fill where a small portion is provided to allow for determination of the therapy effectiveness and patient tolerance.
    /// </summary>
    public static readonly Coding TrialFill = new Coding
    {
      Code = "TF",
      Display = "Trial Fill",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A supply action that provides sufficient material for a single dose.
    /// </summary>
    public static readonly Coding UnitDose = new Coding
    {
      Code = "UD",
      Display = "Unit Dose",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// A supply action that provides sufficient material for a single dose via multiple products.  E.g. 2 50mg tablets for a 100mg unit dose.
    /// </summary>
    public static readonly Coding UnitDoseEquivalent = new Coding
    {
      Code = "UDE",
      Display = "unit dose equivalent",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
  };
}