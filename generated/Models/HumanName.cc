// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1


namespace fhir_R4
{
  /// <summary>
  /// A human's name with the ability to identify parts and usage.
  /// </summary>
  struct HumanName {
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
    /// Applications can assume that a name is current unless it explicitly says that it is temporary or old.
    /// </summary>
    NullableString8* _use;
    /// <summary>
    /// Can provide both a text representation and parts. Applications updating a name SHALL ensure that when both text and parts are present,  no content is included in the text that isn't found in a part.
    /// </summary>
    string* _text;
    /// <summary>
    /// Family Name may be decomposed into specific parts using extensions (de, nl, es related cultures).
    /// </summary>
    string* _family;
    /// <summary>
    /// If only initials are recorded, they may be used in place of the full name parts. Initials may be separated into multiple given names but often aren't due to paractical limitations.  This element is not called "first name" since given names do not always come first.
    /// </summary>
    size_t _given_count;
    string** _given;
    /// <summary>
    /// Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the start of the name.
    /// </summary>
    size_t _prefix_count;
    string** _prefix;
    /// <summary>
    /// Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the end of the name.
    /// </summary>
    size_t _suffix_count;
    string** _suffix;
    /// <summary>
    /// Indicates the period of time when this name was valid for the named person.
    /// </summary>
    Period* _period;
  };
};