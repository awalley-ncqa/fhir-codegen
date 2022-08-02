// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The frequency with which the target must be validated
  /// </summary>
  public static class VerificationresultNeedCodes
  {
    /// <summary>
    /// Initial
    /// </summary>
    public static readonly Coding Initial = new Coding
    {
      Code = "initial",
      Display = "Initial",
      System = "http://terminology.hl7.org/CodeSystem/need"
    };
    /// <summary>
    /// None
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "none",
      Display = "None",
      System = "http://terminology.hl7.org/CodeSystem/need"
    };
    /// <summary>
    /// Periodic
    /// </summary>
    public static readonly Coding Periodic = new Coding
    {
      Code = "periodic",
      Display = "Periodic",
      System = "http://terminology.hl7.org/CodeSystem/need"
    };

    /// <summary>
    /// Literal for code: Initial
    /// </summary>
    public const string LiteralInitial = "initial";

    /// <summary>
    /// Literal for code: NeedInitial
    /// </summary>
    public const string LiteralNeedInitial = "http://terminology.hl7.org/CodeSystem/need#initial";

    /// <summary>
    /// Literal for code: None
    /// </summary>
    public const string LiteralNone = "none";

    /// <summary>
    /// Literal for code: NeedNone
    /// </summary>
    public const string LiteralNeedNone = "http://terminology.hl7.org/CodeSystem/need#none";

    /// <summary>
    /// Literal for code: Periodic
    /// </summary>
    public const string LiteralPeriodic = "periodic";

    /// <summary>
    /// Literal for code: NeedPeriodic
    /// </summary>
    public const string LiteralNeedPeriodic = "http://terminology.hl7.org/CodeSystem/need#periodic";

    /// <summary>
    /// Dictionary for looking up VerificationresultNeed Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "initial", Initial }, 
      { "http://terminology.hl7.org/CodeSystem/need#initial", Initial }, 
      { "none", None }, 
      { "http://terminology.hl7.org/CodeSystem/need#none", None }, 
      { "periodic", Periodic }, 
      { "http://terminology.hl7.org/CodeSystem/need#periodic", Periodic }, 
    };
  };
}