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
  /// The SubscriptionStatus resource describes the state of a Subscription during notifications.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SubscriptionStatus>))]
  public class SubscriptionStatus : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "SubscriptionStatus";
    /// <summary>
    /// Recommended practice: clear errors when status is updated.
    /// </summary>
    public List<CodeableConcept> Error { get; set; }
    /// <summary>
    /// The total number of actual events represented within this notification.  For handshake and heartbeat notifications, this will be zero or not present.  For event-notifications, this number may be one or more, depending on server batching.
    /// </summary>
    public int? EventsInNotification { get; set; }
    /// <summary>
    /// The total number of actual events which have been generated since the Subscription was created (inclusive of this notification) - regardless of how many have been successfully communicated.  This number is NOT incremented for handshake and heartbeat notifications.
    /// </summary>
    public long? EventsSinceSubscriptionStart { get; set; }
    /// <summary>
    /// The status of the subscription, which marks the server state for managing the subscription.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The reference to the Subscription which generated this notification.
    /// </summary>
    public Reference Subscription { get; set; }
    /// <summary>
    /// The reference to the SubscriptionTopic for the Subscription which generated this notification.
    /// </summary>
    public string Topic { get; set; }
    /// <summary>
    /// Extension container element for Topic
    /// </summary>
    public Element _Topic { get; set; }
    /// <summary>
    /// The type of event being conveyed with this notificaiton.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR5.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (EventsSinceSubscriptionStart != null)
      {
        writer.WriteString("eventsSinceSubscriptionStart", EventsSinceSubscriptionStart.ToString());
      }

      if (EventsInNotification != null)
      {
        writer.WriteNumber("eventsInNotification", (int)EventsInNotification!);
      }

      if (Subscription != null)
      {
        writer.WritePropertyName("subscription");
        Subscription.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Topic))
      {
        writer.WriteString("topic", (string)Topic!);
      }

      if (_Topic != null)
      {
        writer.WritePropertyName("_topic");
        _Topic.SerializeJson(writer, options);
      }

      if ((Error != null) && (Error.Count != 0))
      {
        writer.WritePropertyName("error");
        writer.WriteStartArray();

        foreach (CodeableConcept valError in Error)
        {
          valError.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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
        case "error":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Error = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objError = new fhirCsR5.Models.CodeableConcept();
            objError.DeserializeJson(ref reader, options);
            Error.Add(objError);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Error.Count == 0)
          {
            Error = null;
          }

          break;

        case "eventsInNotification":
          EventsInNotification = reader.GetInt32();
          break;

        case "eventsSinceSubscriptionStart":
          string strValEventsSinceSubscriptionStart = reader.GetString();
          if (long.TryParse(strValEventsSinceSubscriptionStart, out long longValEventsSinceSubscriptionStart))
          {
            EventsSinceSubscriptionStart = longValEventsSinceSubscriptionStart;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subscription":
          Subscription = new fhirCsR5.Models.Reference();
          Subscription.DeserializeJson(ref reader, options);
          break;

        case "topic":
          Topic = reader.GetString();
          break;

        case "_topic":
          _Topic = new fhirCsR5.Models.Element();
          _Topic.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR5.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// <summary>
  /// Code Values for the SubscriptionStatus.status field
  /// </summary>
  public static class SubscriptionStatusStatusCodes {
    public const string REQUESTED = "requested";
    public const string ACTIVE = "active";
    public const string ERROR = "error";
    public const string OFF = "off";
    public const string ENTERED_IN_ERROR = "entered-in-error";
  }
  /// <summary>
  /// Code Values for the SubscriptionStatus.type field
  /// </summary>
  public static class SubscriptionStatusTypeCodes {
    public const string HANDSHAKE = "handshake";
    public const string HEARTBEAT = "heartbeat";
    public const string EVENT_NOTIFICATION = "event-notification";
    public const string QUERY_STATUS = "query-status";
  }
}