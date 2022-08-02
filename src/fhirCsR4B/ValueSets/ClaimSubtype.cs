// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes sample Claim SubType codes which are used to distinguish the claim types for example within type institutional there may be subtypes for emergency services, bed stay and transportation.
  /// </summary>
  public static class ClaimSubtypeCodes
  {
    /// <summary>
    /// A claim for emergency services.
    /// </summary>
    public static readonly Coding EmergencyClaim = new Coding
    {
      Code = "emergency",
      Display = "Emergency Claim",
      System = "http://terminology.hl7.org/CodeSystem/ex-claimsubtype"
    };
    /// <summary>
    /// A claim for Orthodontic Services.
    /// </summary>
    public static readonly Coding OrthodonticClaim = new Coding
    {
      Code = "ortho",
      Display = "Orthodontic Claim",
      System = "http://terminology.hl7.org/CodeSystem/ex-claimsubtype"
    };

    /// <summary>
    /// Literal for code: EmergencyClaim
    /// </summary>
    public const string LiteralEmergencyClaim = "emergency";

    /// <summary>
    /// Literal for code: ClaimSubtypeEmergencyClaim
    /// </summary>
    public const string LiteralClaimSubtypeEmergencyClaim = "http://terminology.hl7.org/CodeSystem/ex-claimsubtype#emergency";

    /// <summary>
    /// Literal for code: OrthodonticClaim
    /// </summary>
    public const string LiteralOrthodonticClaim = "ortho";

    /// <summary>
    /// Literal for code: ClaimSubtypeOrthodonticClaim
    /// </summary>
    public const string LiteralClaimSubtypeOrthodonticClaim = "http://terminology.hl7.org/CodeSystem/ex-claimsubtype#ortho";

    /// <summary>
    /// Dictionary for looking up ClaimSubtype Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "emergency", EmergencyClaim }, 
      { "http://terminology.hl7.org/CodeSystem/ex-claimsubtype#emergency", EmergencyClaim }, 
      { "ortho", OrthodonticClaim }, 
      { "http://terminology.hl7.org/CodeSystem/ex-claimsubtype#ortho", OrthodonticClaim }, 
    };
  };
}