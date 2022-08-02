// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for decision modes.
  /// </summary>
  public static class ContractDecisionModeCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding Policy = new Coding
    {
      Code = "policy",
      Display = "Policy",
      System = "http://hl7.org/fhir/contract-decision-mode"
    };

    /// <summary>
    /// Literal for code: Policy
    /// </summary>
    public const string LiteralPolicy = "policy";

    /// <summary>
    /// Literal for code: ContractDecisionModePolicy
    /// </summary>
    public const string LiteralContractDecisionModePolicy = "http://hl7.org/fhir/contract-decision-mode#policy";

    /// <summary>
    /// Dictionary for looking up ContractDecisionMode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "policy", Policy }, 
      { "http://hl7.org/fhir/contract-decision-mode#policy", Policy }, 
    };
  };
}