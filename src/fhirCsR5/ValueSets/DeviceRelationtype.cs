// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Description Needed Here
  /// </summary>
  public static class DeviceRelationtypeCodes
  {
    /// <summary>
    /// The linked device is connected to the current device.
    /// </summary>
    public static readonly Coding Connected = new Coding
    {
      Code = "connected",
      Display = "Connected",
      System = "http://hl7.org/fhir/device-relationtype"
    };
    /// <summary>
    /// The linked device is a container for the current device.
    /// </summary>
    public static readonly Coding Container = new Coding
    {
      Code = "container",
      Display = "container",
      System = "http://hl7.org/fhir/device-relationtype"
    };
    /// <summary>
    /// Gateway.
    /// </summary>
    public static readonly Coding Gateway = new Coding
    {
      Code = "gateway",
      Display = "Gateway",
      System = "http://hl7.org/fhir/device-relationtype"
    };
    /// <summary>
    /// The current device is a previous device and has been replaced by the linked device.
    /// </summary>
    public static readonly Coding Previous = new Coding
    {
      Code = "previous",
      Display = "Previous",
      System = "http://hl7.org/fhir/device-relationtype"
    };
    /// <summary>
    /// The current device replaces the linked device.
    /// </summary>
    public static readonly Coding Replaces = new Coding
    {
      Code = "replaces",
      Display = "Replaces",
      System = "http://hl7.org/fhir/device-relationtype"
    };

    /// <summary>
    /// Literal for code: Connected
    /// </summary>
    public const string LiteralConnected = "connected";

    /// <summary>
    /// Literal for code: DeviceRelationtypeConnected
    /// </summary>
    public const string LiteralDeviceRelationtypeConnected = "http://hl7.org/fhir/device-relationtype#connected";

    /// <summary>
    /// Literal for code: Container
    /// </summary>
    public const string LiteralContainer = "container";

    /// <summary>
    /// Literal for code: DeviceRelationtypeContainer
    /// </summary>
    public const string LiteralDeviceRelationtypeContainer = "http://hl7.org/fhir/device-relationtype#container";

    /// <summary>
    /// Literal for code: Gateway
    /// </summary>
    public const string LiteralGateway = "gateway";

    /// <summary>
    /// Literal for code: DeviceRelationtypeGateway
    /// </summary>
    public const string LiteralDeviceRelationtypeGateway = "http://hl7.org/fhir/device-relationtype#gateway";

    /// <summary>
    /// Literal for code: Previous
    /// </summary>
    public const string LiteralPrevious = "previous";

    /// <summary>
    /// Literal for code: DeviceRelationtypePrevious
    /// </summary>
    public const string LiteralDeviceRelationtypePrevious = "http://hl7.org/fhir/device-relationtype#previous";

    /// <summary>
    /// Literal for code: Replaces
    /// </summary>
    public const string LiteralReplaces = "replaces";

    /// <summary>
    /// Literal for code: DeviceRelationtypeReplaces
    /// </summary>
    public const string LiteralDeviceRelationtypeReplaces = "http://hl7.org/fhir/device-relationtype#replaces";

    /// <summary>
    /// Dictionary for looking up DeviceRelationtype Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "connected", Connected }, 
      { "http://hl7.org/fhir/device-relationtype#connected", Connected }, 
      { "container", Container }, 
      { "http://hl7.org/fhir/device-relationtype#container", Container }, 
      { "gateway", Gateway }, 
      { "http://hl7.org/fhir/device-relationtype#gateway", Gateway }, 
      { "previous", Previous }, 
      { "http://hl7.org/fhir/device-relationtype#previous", Previous }, 
      { "replaces", Replaces }, 
      { "http://hl7.org/fhir/device-relationtype#replaces", Replaces }, 
    };
  };
}