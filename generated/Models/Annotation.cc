// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// A  text note which also  contains information about who made the statement and when.
  /// </summary>
  struct Annotation {
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value that does not contain spaces.
    /// </summary>
    string _id;
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    size_t _extension_count;
    Extension** _extension;
    /// <summary>
    /// Organization is used when there's no need for specific attribution as to who made the comment.
    /// </summary>
    Reference* _authorReference;
    /// <summary>
    /// Organization is used when there's no need for specific attribution as to who made the comment.
    /// </summary>
    string* _authorString;
    /// <summary>
    /// Indicates when this particular annotation was made.
    /// </summary>
    ISO8601_Time* _time;
    /// <summary>
    /// The text of the annotation in markdown format.
    /// </summary>
    NullableString8* _text;
  };
};