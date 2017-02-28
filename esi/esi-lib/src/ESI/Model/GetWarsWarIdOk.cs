/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.3.9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace ESI.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetWarsWarIdOk :  IEquatable<GetWarsWarIdOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWarsWarIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWarsWarIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWarsWarIdOk" /> class.
        /// </summary>
        /// <param name="Aggressor">Aggressor.</param>
        /// <param name="Allies">allied corporations or alliances, each object contains either corporation_id or alliance_id.</param>
        /// <param name="Declared">Time that the war was declared (required).</param>
        /// <param name="Defender">Defender.</param>
        /// <param name="Finished">Time the war ended and shooting was no longer allowed.</param>
        /// <param name="Id">ID of the specified war (required).</param>
        /// <param name="Mutual">Was the war declared mutual by both parties (required).</param>
        /// <param name="OpenForAllies">Is the war currently open for allies or not (required).</param>
        /// <param name="Retracted">Time the war was retracted but both sides could still shoot each other.</param>
        /// <param name="Started">Time when the war started and both sides could shoot each other.</param>
        public GetWarsWarIdOk(GetWarsWarIdAggressor Aggressor = default(GetWarsWarIdAggressor), List<GetWarsWarIdAlly> Allies = default(List<GetWarsWarIdAlly>), DateTime? Declared = default(DateTime?), GetWarsWarIdDefender Defender = default(GetWarsWarIdDefender), DateTime? Finished = default(DateTime?), int? Id = default(int?), bool? Mutual = default(bool?), bool? OpenForAllies = default(bool?), DateTime? Retracted = default(DateTime?), DateTime? Started = default(DateTime?))
        {
            // to ensure "Declared" is required (not null)
            if (Declared == null)
            {
                throw new InvalidDataException("Declared is a required property for GetWarsWarIdOk and cannot be null");
            }
            else
            {
                this.Declared = Declared;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for GetWarsWarIdOk and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Mutual" is required (not null)
            if (Mutual == null)
            {
                throw new InvalidDataException("Mutual is a required property for GetWarsWarIdOk and cannot be null");
            }
            else
            {
                this.Mutual = Mutual;
            }
            // to ensure "OpenForAllies" is required (not null)
            if (OpenForAllies == null)
            {
                throw new InvalidDataException("OpenForAllies is a required property for GetWarsWarIdOk and cannot be null");
            }
            else
            {
                this.OpenForAllies = OpenForAllies;
            }
            this.Aggressor = Aggressor;
            this.Allies = Allies;
            this.Defender = Defender;
            this.Finished = Finished;
            this.Retracted = Retracted;
            this.Started = Started;
        }
        
        /// <summary>
        /// Gets or Sets Aggressor
        /// </summary>
        [DataMember(Name="aggressor", EmitDefaultValue=false)]
        public GetWarsWarIdAggressor Aggressor { get; set; }
        /// <summary>
        /// allied corporations or alliances, each object contains either corporation_id or alliance_id
        /// </summary>
        /// <value>allied corporations or alliances, each object contains either corporation_id or alliance_id</value>
        [DataMember(Name="allies", EmitDefaultValue=false)]
        public List<GetWarsWarIdAlly> Allies { get; set; }
        /// <summary>
        /// Time that the war was declared
        /// </summary>
        /// <value>Time that the war was declared</value>
        [DataMember(Name="declared", EmitDefaultValue=false)]
        public DateTime? Declared { get; set; }
        /// <summary>
        /// Gets or Sets Defender
        /// </summary>
        [DataMember(Name="defender", EmitDefaultValue=false)]
        public GetWarsWarIdDefender Defender { get; set; }
        /// <summary>
        /// Time the war ended and shooting was no longer allowed
        /// </summary>
        /// <value>Time the war ended and shooting was no longer allowed</value>
        [DataMember(Name="finished", EmitDefaultValue=false)]
        public DateTime? Finished { get; set; }
        /// <summary>
        /// ID of the specified war
        /// </summary>
        /// <value>ID of the specified war</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Was the war declared mutual by both parties
        /// </summary>
        /// <value>Was the war declared mutual by both parties</value>
        [DataMember(Name="mutual", EmitDefaultValue=false)]
        public bool? Mutual { get; set; }
        /// <summary>
        /// Is the war currently open for allies or not
        /// </summary>
        /// <value>Is the war currently open for allies or not</value>
        [DataMember(Name="open_for_allies", EmitDefaultValue=false)]
        public bool? OpenForAllies { get; set; }
        /// <summary>
        /// Time the war was retracted but both sides could still shoot each other
        /// </summary>
        /// <value>Time the war was retracted but both sides could still shoot each other</value>
        [DataMember(Name="retracted", EmitDefaultValue=false)]
        public DateTime? Retracted { get; set; }
        /// <summary>
        /// Time when the war started and both sides could shoot each other
        /// </summary>
        /// <value>Time when the war started and both sides could shoot each other</value>
        [DataMember(Name="started", EmitDefaultValue=false)]
        public DateTime? Started { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetWarsWarIdOk {\n");
            sb.Append("  Aggressor: ").Append(Aggressor).Append("\n");
            sb.Append("  Allies: ").Append(Allies).Append("\n");
            sb.Append("  Declared: ").Append(Declared).Append("\n");
            sb.Append("  Defender: ").Append(Defender).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Mutual: ").Append(Mutual).Append("\n");
            sb.Append("  OpenForAllies: ").Append(OpenForAllies).Append("\n");
            sb.Append("  Retracted: ").Append(Retracted).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GetWarsWarIdOk);
        }

        /// <summary>
        /// Returns true if GetWarsWarIdOk instances are equal
        /// </summary>
        /// <param name="other">Instance of GetWarsWarIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWarsWarIdOk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Aggressor == other.Aggressor ||
                    this.Aggressor != null &&
                    this.Aggressor.Equals(other.Aggressor)
                ) && 
                (
                    this.Allies == other.Allies ||
                    this.Allies != null &&
                    this.Allies.SequenceEqual(other.Allies)
                ) && 
                (
                    this.Declared == other.Declared ||
                    this.Declared != null &&
                    this.Declared.Equals(other.Declared)
                ) && 
                (
                    this.Defender == other.Defender ||
                    this.Defender != null &&
                    this.Defender.Equals(other.Defender)
                ) && 
                (
                    this.Finished == other.Finished ||
                    this.Finished != null &&
                    this.Finished.Equals(other.Finished)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Mutual == other.Mutual ||
                    this.Mutual != null &&
                    this.Mutual.Equals(other.Mutual)
                ) && 
                (
                    this.OpenForAllies == other.OpenForAllies ||
                    this.OpenForAllies != null &&
                    this.OpenForAllies.Equals(other.OpenForAllies)
                ) && 
                (
                    this.Retracted == other.Retracted ||
                    this.Retracted != null &&
                    this.Retracted.Equals(other.Retracted)
                ) && 
                (
                    this.Started == other.Started ||
                    this.Started != null &&
                    this.Started.Equals(other.Started)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Aggressor != null)
                    hash = hash * 59 + this.Aggressor.GetHashCode();
                if (this.Allies != null)
                    hash = hash * 59 + this.Allies.GetHashCode();
                if (this.Declared != null)
                    hash = hash * 59 + this.Declared.GetHashCode();
                if (this.Defender != null)
                    hash = hash * 59 + this.Defender.GetHashCode();
                if (this.Finished != null)
                    hash = hash * 59 + this.Finished.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Mutual != null)
                    hash = hash * 59 + this.Mutual.GetHashCode();
                if (this.OpenForAllies != null)
                    hash = hash * 59 + this.OpenForAllies.GetHashCode();
                if (this.Retracted != null)
                    hash = hash * 59 + this.Retracted.GetHashCode();
                if (this.Started != null)
                    hash = hash * 59 + this.Started.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}