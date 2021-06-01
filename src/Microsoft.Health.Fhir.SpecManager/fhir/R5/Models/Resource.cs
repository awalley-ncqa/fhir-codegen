// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// This is the base resource type for everything.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamResourceConverter))]
  public class Resource : Base,  IFhirJsonSerializable {
    /// <summary>
    /// Typically, the resource has an id except for cases like the create operation, conditional updates.
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Extension container element for Id
    /// </summary>
    public Element _Id { get; set; }
    /// <summary>
    /// Asserting this rule set restricts the content to be only understood by a limited set of trading partners. This inherently limits the usefulness of the data in the long term. However, the existing health eco-system is highly fractured, and not yet ready to define, collect, and exchange data in a generally computable sense. Wherever possible, implementers and/or specification writers should avoid using this element. Often, when used, the URL is a reference to an implementation guide that defines these special rules as part of it's narrative along with other profiles, value sets, etc.
    /// </summary>
    public string ImplicitRules { get; set; }
    /// <summary>
    /// Extension container element for ImplicitRules
    /// </summary>
    public Element _ImplicitRules { get; set; }
    /// <summary>
    /// Language is provided to support indexing and accessibility (typically, services such as text to speech use the language tag). The html language tag in the narrative applies  to the narrative. The language tag on the resource may be used to specify the language of other presentations generated from the data in the resource. Not all the content has to be in the base language. The Resource.language should not be assumed to apply to the narrative automatically. If a language is specified, it should it also be specified on the div element in the html (see rules in HTML5 for information about the relationship between xml:lang and the html lang attribute).
    /// </summary>
    public string Language { get; set; }
    /// <summary>
    /// Extension container element for Language
    /// </summary>
    public Element _Language { get; set; }
    /// <summary>
    /// The metadata about the resource. This is content that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.
    /// </summary>
    public Meta Meta { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.Base)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Id))
      {
        writer.WriteString("id", (string)Id!);
      }

      if (_Id != null)
      {
        writer.WritePropertyName("_id");
        _Id.SerializeJson(writer, options);
      }

      if (Meta != null)
      {
        writer.WritePropertyName("meta");
        Meta.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ImplicitRules))
      {
        writer.WriteString("implicitRules", (string)ImplicitRules!);
      }

      if (_ImplicitRules != null)
      {
        writer.WritePropertyName("_implicitRules");
        _ImplicitRules.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Language))
      {
        writer.WriteString("language", (string)Language!);
      }

      if (_Language != null)
      {
        writer.WritePropertyName("_language");
        _Language.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "id":
          Id = reader.GetString();
          break;

        case "_id":
          _Id = new fhirCsR5.Models.Element();
          _Id.DeserializeJson(ref reader, options);
          break;

        case "implicitRules":
          ImplicitRules = reader.GetString();
          break;

        case "_implicitRules":
          _ImplicitRules = new fhirCsR5.Models.Element();
          _ImplicitRules.DeserializeJson(ref reader, options);
          break;

        case "language":
          Language = reader.GetString();
          break;

        case "_language":
          _Language = new fhirCsR5.Models.Element();
          _Language.DeserializeJson(ref reader, options);
          break;

        case "meta":
          Meta = new fhirCsR5.Models.Meta();
          Meta.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.Base)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}