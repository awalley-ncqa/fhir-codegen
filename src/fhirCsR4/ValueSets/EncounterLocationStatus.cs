// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The status of the location.
  /// </summary>
  public static class EncounterLocationStatusCodes
  {
    /// <summary>
    /// The patient is currently at this location, or was between the period specified.
    /// A system may update these records when the patient leaves the location to either reserved, or completed.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/encounter-location-status"
    };
    /// <summary>
    /// The patient was at this location during the period specified.
    /// Not to be used when the patient is currently at the location.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/encounter-location-status"
    };
    /// <summary>
    /// The patient is planned to be moved to this location at some point in the future.
    /// </summary>
    public static readonly Coding Planned = new Coding
    {
      Code = "planned",
      Display = "Planned",
      System = "http://hl7.org/fhir/encounter-location-status"
    };
    /// <summary>
    /// This location is held empty for this patient.
    /// </summary>
    public static readonly Coding Reserved = new Coding
    {
      Code = "reserved",
      Display = "Reserved",
      System = "http://hl7.org/fhir/encounter-location-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: EncounterLocationStatusActive
    /// </summary>
    public const string LiteralEncounterLocationStatusActive = "http://hl7.org/fhir/encounter-location-status#active";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: EncounterLocationStatusCompleted
    /// </summary>
    public const string LiteralEncounterLocationStatusCompleted = "http://hl7.org/fhir/encounter-location-status#completed";

    /// <summary>
    /// Literal for code: Planned
    /// </summary>
    public const string LiteralPlanned = "planned";

    /// <summary>
    /// Literal for code: EncounterLocationStatusPlanned
    /// </summary>
    public const string LiteralEncounterLocationStatusPlanned = "http://hl7.org/fhir/encounter-location-status#planned";

    /// <summary>
    /// Literal for code: Reserved
    /// </summary>
    public const string LiteralReserved = "reserved";

    /// <summary>
    /// Literal for code: EncounterLocationStatusReserved
    /// </summary>
    public const string LiteralEncounterLocationStatusReserved = "http://hl7.org/fhir/encounter-location-status#reserved";

    /// <summary>
    /// Dictionary for looking up EncounterLocationStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/encounter-location-status#active", Active }, 
      { "completed", Completed }, 
      { "http://hl7.org/fhir/encounter-location-status#completed", Completed }, 
      { "planned", Planned }, 
      { "http://hl7.org/fhir/encounter-location-status#planned", Planned }, 
      { "reserved", Reserved }, 
      { "http://hl7.org/fhir/encounter-location-status#reserved", Reserved }, 
    };
  };
}