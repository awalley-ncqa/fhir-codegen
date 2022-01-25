// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for Provenance
  /// </summary>
  public static class ProvenanceJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Provenance into JSON
    /// </summary>
    public static void SerializeJson(this Provenance current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Provenance");
      // Complex: Provenance, Export: Provenance, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Target != null) && (current.Target.Count != 0))
      {
        writer.WritePropertyName("target");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Target)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Occurred != null)
      {
        switch (current.Occurred)
        {
          case Period v_Period:
            writer.WritePropertyName("occurredPeriod");
            v_Period.SerializeJson(writer, options);
            break;
          case FhirDateTime v_FhirDateTime:
            if (v_FhirDateTime != null)
            {
              if (!string.IsNullOrEmpty(v_FhirDateTime.Value))
              {
                writer.WriteString("occurredDateTime",v_FhirDateTime.Value);
              }
              if (v_FhirDateTime.HasExtensions() || (!string.IsNullOrEmpty(v_FhirDateTime.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_occurredDateTime",false,v_FhirDateTime.Extension,v_FhirDateTime.ElementId);
              }
            }
            break;
        }
      }
      writer.WriteString("recorded",((DateTimeOffset)current.RecordedElement.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK",System.Globalization.CultureInfo.InvariantCulture));

      if ((current.PolicyElement != null) && (current.PolicyElement.Count != 0))
      {
        int valueCount = 0;
        int extensionCount = 0;
        foreach (FhirUri val in current.PolicyElement)
        {
          if (!string.IsNullOrEmpty(val.Value)) { valueCount++; }
          if (val.HasExtensions()) { extensionCount++; }
        }

        if (valueCount > 0)
        {
          writer.WritePropertyName("policy");
          writer.WriteStartArray();
          foreach (FhirUri val in current.PolicyElement)
          {
            if (string.IsNullOrEmpty(val.Value))
            {
              writer.WriteNullValue();
            }
            else
            {
              writer.WriteStringValue(val.Value);
            }
          }

          writer.WriteEndArray();
        }

        if (extensionCount > 0)
        {
          writer.WritePropertyName("_policy");
          writer.WriteStartArray();
          foreach (FhirUri val in current.PolicyElement)
          {
            if (val.HasExtensions() || (!string.IsNullOrEmpty(val.ElementId)))
            {
              JsonStreamUtilities.SerializeExtensionList(writer,options,string.Empty,true,val.Extension,val.ElementId);
            }
            else
            {
              writer.WriteNullValue();
            }

          }

          writer.WriteEndArray();
        }
      }

      if (current.Location != null)
      {
        writer.WritePropertyName("location");
        current.Location.SerializeJson(writer, options);
      }

      if ((current.Reason != null) && (current.Reason.Count != 0))
      {
        writer.WritePropertyName("reason");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Reason)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Activity != null)
      {
        writer.WritePropertyName("activity");
        current.Activity.SerializeJson(writer, options);
      }

      if ((current.Agent != null) && (current.Agent.Count != 0))
      {
        writer.WritePropertyName("agent");
        writer.WriteStartArray();
        foreach (Provenance.AgentComponent val in current.Agent)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Entity != null) && (current.Entity.Count != 0))
      {
        writer.WritePropertyName("entity");
        writer.WriteStartArray();
        foreach (Provenance.EntityComponent val in current.Entity)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Signature != null) && (current.Signature.Count != 0))
      {
        writer.WritePropertyName("signature");
        writer.WriteStartArray();
        foreach (Signature val in current.Signature)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Provenance
    /// </summary>
    public static void DeserializeJson(this Provenance current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Provenance >>> Provenance.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Provenance: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Provenance
    /// </summary>
    public static void DeserializeJsonProperty(this Provenance current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "target":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Provenance error reading 'target' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Target = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Target = new Hl7.Fhir.Model.ResourceReference();
            v_Target.DeserializeJson(ref reader, options);
            current.Target.Add(v_Target);

            if (!reader.Read())
            {
              throw new JsonException($"Provenance error reading 'target' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Target.Count == 0)
          {
            current.Target = null;
          }
          break;

        case "occurredPeriod":
          current.Occurred = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Occurred).DeserializeJson(ref reader, options);
          break;

        case "occurredDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Occurred = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Occurred = new FhirDateTime(reader.GetString());
          }
          break;

        case "_occurredDateTime":
          if (current.Occurred == null) { current.Occurred = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Occurred).DeserializeJson(ref reader, options);
          break;

        case "recorded":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.RecordedElement = new Instant();
            reader.Skip();
          }
          else
          {
            current.RecordedElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          }
          break;

        case "_recorded":
          if (current.RecordedElement == null) { current.RecordedElement = new Instant(); }
          ((Hl7.Fhir.Model.Element)current.RecordedElement).DeserializeJson(ref reader, options);
          break;

        case "policy":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Provenance error reading 'policy' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PolicyElement = new List<FhirUri>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.PolicyElement.Add(new FhirUri());
              reader.Skip();
            }
            else
            {
              current.PolicyElement.Add(new FhirUri(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"Provenance error reading 'policy' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PolicyElement.Count == 0)
          {
            current.PolicyElement = null;
          }
          break;

        case "_policy":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Provenance error reading 'policy' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_policy = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_policy >= current.PolicyElement.Count)
            {
              current.PolicyElement.Add(new FhirUri());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.PolicyElement[i_policy++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"Provenance error reading 'policy' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "location":
          current.Location = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Location).DeserializeJson(ref reader, options);
          break;

        case "reason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Provenance error reading 'reason' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Reason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Reason = new Hl7.Fhir.Model.CodeableConcept();
            v_Reason.DeserializeJson(ref reader, options);
            current.Reason.Add(v_Reason);

            if (!reader.Read())
            {
              throw new JsonException($"Provenance error reading 'reason' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Reason.Count == 0)
          {
            current.Reason = null;
          }
          break;

        case "activity":
          current.Activity = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Activity).DeserializeJson(ref reader, options);
          break;

        case "agent":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Provenance error reading 'agent' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Agent = new List<Provenance.AgentComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Provenance.AgentComponent v_Agent = new Hl7.Fhir.Model.Provenance.AgentComponent();
            v_Agent.DeserializeJson(ref reader, options);
            current.Agent.Add(v_Agent);

            if (!reader.Read())
            {
              throw new JsonException($"Provenance error reading 'agent' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Agent.Count == 0)
          {
            current.Agent = null;
          }
          break;

        case "entity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Provenance error reading 'entity' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Entity = new List<Provenance.EntityComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Provenance.EntityComponent v_Entity = new Hl7.Fhir.Model.Provenance.EntityComponent();
            v_Entity.DeserializeJson(ref reader, options);
            current.Entity.Add(v_Entity);

            if (!reader.Read())
            {
              throw new JsonException($"Provenance error reading 'entity' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Entity.Count == 0)
          {
            current.Entity = null;
          }
          break;

        case "signature":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Provenance error reading 'signature' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Signature = new List<Signature>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Signature v_Signature = new Hl7.Fhir.Model.Signature();
            v_Signature.DeserializeJson(ref reader, options);
            current.Signature.Add(v_Signature);

            if (!reader.Read())
            {
              throw new JsonException($"Provenance error reading 'signature' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Signature.Count == 0)
          {
            current.Signature = null;
          }
          break;

        // Complex: Provenance, Export: Provenance, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Provenance#Agent into JSON
    /// </summary>
    public static void SerializeJson(this Provenance.AgentComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Provenance#Agent, Export: AgentComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Type != null)
      {
        writer.WritePropertyName("type");
        current.Type.SerializeJson(writer, options);
      }

      if ((current.Role != null) && (current.Role.Count != 0))
      {
        writer.WritePropertyName("role");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Role)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WritePropertyName("who");
      current.Who.SerializeJson(writer, options);

      if (current.OnBehalfOf != null)
      {
        writer.WritePropertyName("onBehalfOf");
        current.OnBehalfOf.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Provenance#Agent
    /// </summary>
    public static void DeserializeJson(this Provenance.AgentComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Provenance.AgentComponent >>> Provenance#Agent.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Provenance.AgentComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Provenance#Agent
    /// </summary>
    public static void DeserializeJsonProperty(this Provenance.AgentComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "role":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"AgentComponent error reading 'role' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Role = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Role = new Hl7.Fhir.Model.CodeableConcept();
            v_Role.DeserializeJson(ref reader, options);
            current.Role.Add(v_Role);

            if (!reader.Read())
            {
              throw new JsonException($"AgentComponent error reading 'role' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Role.Count == 0)
          {
            current.Role = null;
          }
          break;

        case "who":
          current.Who = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Who).DeserializeJson(ref reader, options);
          break;

        case "onBehalfOf":
          current.OnBehalfOf = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.OnBehalfOf).DeserializeJson(ref reader, options);
          break;

        // Complex: agent, Export: AgentComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Provenance#Entity into JSON
    /// </summary>
    public static void SerializeJson(this Provenance.EntityComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Provenance#Entity, Export: EntityComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("role",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.RoleElement.Value));

      writer.WritePropertyName("what");
      current.What.SerializeJson(writer, options);

      if ((current.Agent != null) && (current.Agent.Count != 0))
      {
        writer.WritePropertyName("agent");
        writer.WriteStartArray();
        foreach (Provenance.AgentComponent val in current.Agent)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Provenance#Entity
    /// </summary>
    public static void DeserializeJson(this Provenance.EntityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Provenance.EntityComponent >>> Provenance#Entity.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Provenance.EntityComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Provenance#Entity
    /// </summary>
    public static void DeserializeJsonProperty(this Provenance.EntityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "role":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.RoleElement = new Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>();
            reader.Skip();
          }
          else
          {
            current.RoleElement = new Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>(reader.GetString()));
          }
          break;

        case "_role":
          if (current.RoleElement == null) { current.RoleElement = new Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>(); }
          ((Hl7.Fhir.Model.Element)current.RoleElement).DeserializeJson(ref reader, options);
          break;

        case "what":
          current.What = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.What).DeserializeJson(ref reader, options);
          break;

        case "agent":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EntityComponent error reading 'agent' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Agent = new List<Provenance.AgentComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Provenance.AgentComponent v_Agent = new Hl7.Fhir.Model.Provenance.AgentComponent();
            v_Agent.DeserializeJson(ref reader, options);
            current.Agent.Add(v_Agent);

            if (!reader.Read())
            {
              throw new JsonException($"EntityComponent error reading 'agent' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Agent.Count == 0)
          {
            current.Agent = null;
          }
          break;

        // Complex: entity, Export: EntityComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class ProvenanceJsonConverter : JsonConverter<Provenance>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Provenance value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Provenance Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Provenance target = new Provenance();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file