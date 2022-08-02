// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Used to specify why the normally expected content of the data element is missing.
  /// </summary>
  public static class DataAbsentReasonCodes
  {
    /// <summary>
    /// The content of the data is represented in the resource narrative.
    /// </summary>
    public static readonly Coding AsText = new Coding
    {
      Code = "as-text",
      Display = "As Text",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The source was asked but declined to answer.
    /// </summary>
    public static readonly Coding AskedButDeclined = new Coding
    {
      Code = "asked-declined",
      Display = "Asked But Declined",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The source was asked but does not know the value.
    /// </summary>
    public static readonly Coding AskedButUnknown = new Coding
    {
      Code = "asked-unknown",
      Display = "Asked But Unknown",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// Some system or workflow process error means that the information is not available.
    /// </summary>
    public static readonly Coding Error = new Coding
    {
      Code = "error",
      Display = "Error",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The information is not available due to security, privacy or related reasons.
    /// </summary>
    public static readonly Coding Masked = new Coding
    {
      Code = "masked",
      Display = "Masked",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The numeric value is excessively low and unrepresentable due to a floating point processing error.
    /// </summary>
    public static readonly Coding NegativeInfinityNINF = new Coding
    {
      Code = "negative-infinity",
      Display = "Negative Infinity (NINF)",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The numeric value is undefined or unrepresentable due to a floating point processing error.
    /// </summary>
    public static readonly Coding NotANumberNaN = new Coding
    {
      Code = "not-a-number",
      Display = "Not a Number (NaN)",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// There is no proper value for this element (e.g. last menstrual period for a male).
    /// </summary>
    public static readonly Coding NotApplicable = new Coding
    {
      Code = "not-applicable",
      Display = "Not Applicable",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The workflow didn't lead to this value being known.
    /// </summary>
    public static readonly Coding NotAsked = new Coding
    {
      Code = "not-asked",
      Display = "Not Asked",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The value is not available because the observation procedure (test, etc.) was not performed.
    /// </summary>
    public static readonly Coding NotPerformed = new Coding
    {
      Code = "not-performed",
      Display = "Not Performed",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The value is not permitted in this context (e.g. due to profiles, or the base data types).
    /// </summary>
    public static readonly Coding NotPermitted = new Coding
    {
      Code = "not-permitted",
      Display = "Not Permitted",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The numeric value is excessively high and unrepresentable due to a floating point processing error.
    /// </summary>
    public static readonly Coding PositiveInfinityPINF = new Coding
    {
      Code = "positive-infinity",
      Display = "Positive Infinity (PINF)",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// There is reason to expect (from the workflow) that the value may become known.
    /// </summary>
    public static readonly Coding TemporarilyUnknown = new Coding
    {
      Code = "temp-unknown",
      Display = "Temporarily Unknown",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The value is expected to exist but is not known.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The source system wasn't capable of supporting this element.
    /// </summary>
    public static readonly Coding Unsupported = new Coding
    {
      Code = "unsupported",
      Display = "Unsupported",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };

    /// <summary>
    /// Literal for code: AsText
    /// </summary>
    public const string LiteralAsText = "as-text";

    /// <summary>
    /// Literal for code: DataAbsentReasonAsText
    /// </summary>
    public const string LiteralDataAbsentReasonAsText = "http://terminology.hl7.org/CodeSystem/data-absent-reason#as-text";

    /// <summary>
    /// Literal for code: AskedButDeclined
    /// </summary>
    public const string LiteralAskedButDeclined = "asked-declined";

    /// <summary>
    /// Literal for code: DataAbsentReasonAskedButDeclined
    /// </summary>
    public const string LiteralDataAbsentReasonAskedButDeclined = "http://terminology.hl7.org/CodeSystem/data-absent-reason#asked-declined";

    /// <summary>
    /// Literal for code: AskedButUnknown
    /// </summary>
    public const string LiteralAskedButUnknown = "asked-unknown";

    /// <summary>
    /// Literal for code: DataAbsentReasonAskedButUnknown
    /// </summary>
    public const string LiteralDataAbsentReasonAskedButUnknown = "http://terminology.hl7.org/CodeSystem/data-absent-reason#asked-unknown";

    /// <summary>
    /// Literal for code: Error
    /// </summary>
    public const string LiteralError = "error";

    /// <summary>
    /// Literal for code: DataAbsentReasonError
    /// </summary>
    public const string LiteralDataAbsentReasonError = "http://terminology.hl7.org/CodeSystem/data-absent-reason#error";

    /// <summary>
    /// Literal for code: Masked
    /// </summary>
    public const string LiteralMasked = "masked";

    /// <summary>
    /// Literal for code: DataAbsentReasonMasked
    /// </summary>
    public const string LiteralDataAbsentReasonMasked = "http://terminology.hl7.org/CodeSystem/data-absent-reason#masked";

    /// <summary>
    /// Literal for code: NegativeInfinityNINF
    /// </summary>
    public const string LiteralNegativeInfinityNINF = "negative-infinity";

    /// <summary>
    /// Literal for code: DataAbsentReasonNegativeInfinityNINF
    /// </summary>
    public const string LiteralDataAbsentReasonNegativeInfinityNINF = "http://terminology.hl7.org/CodeSystem/data-absent-reason#negative-infinity";

    /// <summary>
    /// Literal for code: NotANumberNaN
    /// </summary>
    public const string LiteralNotANumberNaN = "not-a-number";

    /// <summary>
    /// Literal for code: DataAbsentReasonNotANumberNaN
    /// </summary>
    public const string LiteralDataAbsentReasonNotANumberNaN = "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-a-number";

    /// <summary>
    /// Literal for code: NotApplicable
    /// </summary>
    public const string LiteralNotApplicable = "not-applicable";

    /// <summary>
    /// Literal for code: DataAbsentReasonNotApplicable
    /// </summary>
    public const string LiteralDataAbsentReasonNotApplicable = "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-applicable";

    /// <summary>
    /// Literal for code: NotAsked
    /// </summary>
    public const string LiteralNotAsked = "not-asked";

    /// <summary>
    /// Literal for code: DataAbsentReasonNotAsked
    /// </summary>
    public const string LiteralDataAbsentReasonNotAsked = "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-asked";

    /// <summary>
    /// Literal for code: NotPerformed
    /// </summary>
    public const string LiteralNotPerformed = "not-performed";

    /// <summary>
    /// Literal for code: DataAbsentReasonNotPerformed
    /// </summary>
    public const string LiteralDataAbsentReasonNotPerformed = "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-performed";

    /// <summary>
    /// Literal for code: NotPermitted
    /// </summary>
    public const string LiteralNotPermitted = "not-permitted";

    /// <summary>
    /// Literal for code: DataAbsentReasonNotPermitted
    /// </summary>
    public const string LiteralDataAbsentReasonNotPermitted = "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-permitted";

    /// <summary>
    /// Literal for code: PositiveInfinityPINF
    /// </summary>
    public const string LiteralPositiveInfinityPINF = "positive-infinity";

    /// <summary>
    /// Literal for code: DataAbsentReasonPositiveInfinityPINF
    /// </summary>
    public const string LiteralDataAbsentReasonPositiveInfinityPINF = "http://terminology.hl7.org/CodeSystem/data-absent-reason#positive-infinity";

    /// <summary>
    /// Literal for code: TemporarilyUnknown
    /// </summary>
    public const string LiteralTemporarilyUnknown = "temp-unknown";

    /// <summary>
    /// Literal for code: DataAbsentReasonTemporarilyUnknown
    /// </summary>
    public const string LiteralDataAbsentReasonTemporarilyUnknown = "http://terminology.hl7.org/CodeSystem/data-absent-reason#temp-unknown";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: DataAbsentReasonUnknown
    /// </summary>
    public const string LiteralDataAbsentReasonUnknown = "http://terminology.hl7.org/CodeSystem/data-absent-reason#unknown";

    /// <summary>
    /// Literal for code: Unsupported
    /// </summary>
    public const string LiteralUnsupported = "unsupported";

    /// <summary>
    /// Literal for code: DataAbsentReasonUnsupported
    /// </summary>
    public const string LiteralDataAbsentReasonUnsupported = "http://terminology.hl7.org/CodeSystem/data-absent-reason#unsupported";

    /// <summary>
    /// Dictionary for looking up DataAbsentReason Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "as-text", AsText }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#as-text", AsText }, 
      { "asked-declined", AskedButDeclined }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#asked-declined", AskedButDeclined }, 
      { "asked-unknown", AskedButUnknown }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#asked-unknown", AskedButUnknown }, 
      { "error", Error }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#error", Error }, 
      { "masked", Masked }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#masked", Masked }, 
      { "negative-infinity", NegativeInfinityNINF }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#negative-infinity", NegativeInfinityNINF }, 
      { "not-a-number", NotANumberNaN }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-a-number", NotANumberNaN }, 
      { "not-applicable", NotApplicable }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-applicable", NotApplicable }, 
      { "not-asked", NotAsked }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-asked", NotAsked }, 
      { "not-performed", NotPerformed }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-performed", NotPerformed }, 
      { "not-permitted", NotPermitted }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#not-permitted", NotPermitted }, 
      { "positive-infinity", PositiveInfinityPINF }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#positive-infinity", PositiveInfinityPINF }, 
      { "temp-unknown", TemporarilyUnknown }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#temp-unknown", TemporarilyUnknown }, 
      { "unknown", Unknown }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#unknown", Unknown }, 
      { "unsupported", Unsupported }, 
      { "http://terminology.hl7.org/CodeSystem/data-absent-reason#unsupported", Unsupported }, 
    };
  };
}