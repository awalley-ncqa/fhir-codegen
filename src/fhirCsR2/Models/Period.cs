// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR2.Serialization;

namespace fhirCsR2.Models
{
  /// <summary>
  /// A time period defined by a start and end date and optionally time.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<Period>))]
  public class Period : Element,  IFhirJsonSerializable {
    /// <summary>
    /// The end of the period. If the end of the period is missing, it means that the period is ongoing. The start may be in the past, and the end date in the future, which means that period is expected/planned to end at that time.
    /// </summary>
    public string End { get; set; }
    /// <summary>
    /// Extension container element for End
    /// </summary>
    public Element _End { get; set; }
    /// <summary>
    /// The start of the period. The boundary is inclusive.
    /// </summary>
    public string Start { get; set; }
    /// <summary>
    /// Extension container element for Start
    /// </summary>
    public Element _Start { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR2.Models.Element)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Start))
      {
        writer.WriteString("start", (string)Start!);
      }

      if (_Start != null)
      {
        writer.WritePropertyName("_start");
        _Start.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(End))
      {
        writer.WriteString("end", (string)End!);
      }

      if (_End != null)
      {
        writer.WritePropertyName("_end");
        _End.SerializeJson(writer, options);
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
        case "end":
          End = reader.GetString();
          break;

        case "_end":
          _End = new fhirCsR2.Models.Element();
          _End.DeserializeJson(ref reader, options);
          break;

        case "start":
          Start = reader.GetString();
          break;

        case "_start":
          _Start = new fhirCsR2.Models.Element();
          _Start.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
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