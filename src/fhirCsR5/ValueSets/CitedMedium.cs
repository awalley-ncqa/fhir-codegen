// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// NLM codes Internet or Print.
  /// </summary>
  public static class CitedMediumCodes
  {
    /// <summary>
    /// Online publication in a periodic release. Used to match NLM JournalIssue CitedMedium code for online version.
    /// </summary>
    public static readonly Coding Internet = new Coding
    {
      Code = "internet",
      Display = "Internet",
      System = "http://terminology.hl7.org/CodeSystem/cited-medium"
    };
    /// <summary>
    /// Online publication without any periodic release. Used for article specific publication date which could be the same as or different from journal issue publication date.
    /// </summary>
    public static readonly Coding InternetWithoutIssue = new Coding
    {
      Code = "internet-without-issue",
      Display = "Internet without issue",
      System = "http://terminology.hl7.org/CodeSystem/cited-medium"
    };
    /// <summary>
    /// Publication in a physical device for electronic data storage, organized in issues for periodic release.
    /// </summary>
    public static readonly Coding OfflineDigitalStorage = new Coding
    {
      Code = "offline-digital-storage",
      Display = "Offline Digital Storage",
      System = "http://terminology.hl7.org/CodeSystem/cited-medium"
    };
    /// <summary>
    /// Publication in a physical device for electronic data storage, without any periodic release.
    /// </summary>
    public static readonly Coding OfflineDigitalStorageWithoutIssue = new Coding
    {
      Code = "offline-digital-storage-without-issue",
      Display = "Offline Digital Storage without issue",
      System = "http://terminology.hl7.org/CodeSystem/cited-medium"
    };
    /// <summary>
    /// Print publication in a periodic release. Used to match NLM JournalIssue CitedMedium code for print version.
    /// </summary>
    public static readonly Coding Print = new Coding
    {
      Code = "print",
      Display = "Print",
      System = "http://terminology.hl7.org/CodeSystem/cited-medium"
    };
    /// <summary>
    /// Print publication without any periodic release.
    /// </summary>
    public static readonly Coding PrintWithoutIssue = new Coding
    {
      Code = "print-without-issue",
      Display = "Print without issue",
      System = "http://terminology.hl7.org/CodeSystem/cited-medium"
    };

    /// <summary>
    /// Literal for code: Internet
    /// </summary>
    public const string LiteralInternet = "internet";

    /// <summary>
    /// Literal for code: CitedMediumInternet
    /// </summary>
    public const string LiteralCitedMediumInternet = "http://terminology.hl7.org/CodeSystem/cited-medium#internet";

    /// <summary>
    /// Literal for code: InternetWithoutIssue
    /// </summary>
    public const string LiteralInternetWithoutIssue = "internet-without-issue";

    /// <summary>
    /// Literal for code: CitedMediumInternetWithoutIssue
    /// </summary>
    public const string LiteralCitedMediumInternetWithoutIssue = "http://terminology.hl7.org/CodeSystem/cited-medium#internet-without-issue";

    /// <summary>
    /// Literal for code: OfflineDigitalStorage
    /// </summary>
    public const string LiteralOfflineDigitalStorage = "offline-digital-storage";

    /// <summary>
    /// Literal for code: CitedMediumOfflineDigitalStorage
    /// </summary>
    public const string LiteralCitedMediumOfflineDigitalStorage = "http://terminology.hl7.org/CodeSystem/cited-medium#offline-digital-storage";

    /// <summary>
    /// Literal for code: OfflineDigitalStorageWithoutIssue
    /// </summary>
    public const string LiteralOfflineDigitalStorageWithoutIssue = "offline-digital-storage-without-issue";

    /// <summary>
    /// Literal for code: CitedMediumOfflineDigitalStorageWithoutIssue
    /// </summary>
    public const string LiteralCitedMediumOfflineDigitalStorageWithoutIssue = "http://terminology.hl7.org/CodeSystem/cited-medium#offline-digital-storage-without-issue";

    /// <summary>
    /// Literal for code: Print
    /// </summary>
    public const string LiteralPrint = "print";

    /// <summary>
    /// Literal for code: CitedMediumPrint
    /// </summary>
    public const string LiteralCitedMediumPrint = "http://terminology.hl7.org/CodeSystem/cited-medium#print";

    /// <summary>
    /// Literal for code: PrintWithoutIssue
    /// </summary>
    public const string LiteralPrintWithoutIssue = "print-without-issue";

    /// <summary>
    /// Literal for code: CitedMediumPrintWithoutIssue
    /// </summary>
    public const string LiteralCitedMediumPrintWithoutIssue = "http://terminology.hl7.org/CodeSystem/cited-medium#print-without-issue";

    /// <summary>
    /// Dictionary for looking up CitedMedium Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "internet", Internet }, 
      { "http://terminology.hl7.org/CodeSystem/cited-medium#internet", Internet }, 
      { "internet-without-issue", InternetWithoutIssue }, 
      { "http://terminology.hl7.org/CodeSystem/cited-medium#internet-without-issue", InternetWithoutIssue }, 
      { "offline-digital-storage", OfflineDigitalStorage }, 
      { "http://terminology.hl7.org/CodeSystem/cited-medium#offline-digital-storage", OfflineDigitalStorage }, 
      { "offline-digital-storage-without-issue", OfflineDigitalStorageWithoutIssue }, 
      { "http://terminology.hl7.org/CodeSystem/cited-medium#offline-digital-storage-without-issue", OfflineDigitalStorageWithoutIssue }, 
      { "print", Print }, 
      { "http://terminology.hl7.org/CodeSystem/cited-medium#print", Print }, 
      { "print-without-issue", PrintWithoutIssue }, 
      { "http://terminology.hl7.org/CodeSystem/cited-medium#print-without-issue", PrintWithoutIssue }, 
    };
  };
}