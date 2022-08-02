// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// The current state of the list
  /// </summary>
  public static class ListStatusCodes
  {
    /// <summary>
    /// The list is considered to be an active part of the patient's record.
    /// </summary>
    public static readonly Coding Current = new Coding
    {
      Code = "current",
      Display = "Current",
      System = "http://hl7.org/fhir/list-status"
    };
    /// <summary>
    /// The list was never accurate.  It is retained for medico-legal purposes only.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered In Error",
      System = "http://hl7.org/fhir/list-status"
    };
    /// <summary>
    /// The list is "old" and should no longer be considered accurate or relevant.
    /// </summary>
    public static readonly Coding Retired = new Coding
    {
      Code = "retired",
      Display = "Retired",
      System = "http://hl7.org/fhir/list-status"
    };

    /// <summary>
    /// Literal for code: Current
    /// </summary>
    public const string LiteralCurrent = "current";

    /// <summary>
    /// Literal for code: ListStatusCurrent
    /// </summary>
    public const string LiteralListStatusCurrent = "http://hl7.org/fhir/list-status#current";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: ListStatusEnteredInError
    /// </summary>
    public const string LiteralListStatusEnteredInError = "http://hl7.org/fhir/list-status#entered-in-error";

    /// <summary>
    /// Literal for code: Retired
    /// </summary>
    public const string LiteralRetired = "retired";

    /// <summary>
    /// Literal for code: ListStatusRetired
    /// </summary>
    public const string LiteralListStatusRetired = "http://hl7.org/fhir/list-status#retired";

    /// <summary>
    /// Dictionary for looking up ListStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "current", Current }, 
      { "http://hl7.org/fhir/list-status#current", Current }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/list-status#entered-in-error", EnteredInError }, 
      { "retired", Retired }, 
      { "http://hl7.org/fhir/list-status#retired", Retired }, 
    };
  };
}