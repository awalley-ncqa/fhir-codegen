// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The reason why the supply item was requested.
  /// </summary>
  public static class SupplyrequestReasonCodes
  {
    /// <summary>
    /// The supply has been requested for use in direct patient care.
    /// </summary>
    public static readonly Coding PatientCare = new Coding
    {
      Code = "patient-care",
      Display = "Patient Care",
      System = "http://terminology.hl7.org/CodeSystem/supplyrequest-reason"
    };
    /// <summary>
    /// The supply has been requested for creating or replenishing ward stock.
    /// </summary>
    public static readonly Coding WardStock = new Coding
    {
      Code = "ward-stock",
      Display = "Ward Stock",
      System = "http://terminology.hl7.org/CodeSystem/supplyrequest-reason"
    };
  };
}