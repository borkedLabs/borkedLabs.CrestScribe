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
    /// alliance object
    /// </summary>
    [DataContract]
    public partial class GetCorporationsCorporationIdAlliancehistoryAlliance :  IEquatable<GetCorporationsCorporationIdAlliancehistoryAlliance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdAlliancehistoryAlliance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdAlliancehistoryAlliance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdAlliancehistoryAlliance" /> class.
        /// </summary>
        /// <param name="AllianceId">alliance_id integer (required).</param>
        /// <param name="IsDeleted">True if the alliance has been deleted (required).</param>
        public GetCorporationsCorporationIdAlliancehistoryAlliance(int? AllianceId = default(int?), bool? IsDeleted = default(bool?))
        {
            // to ensure "AllianceId" is required (not null)
            if (AllianceId == null)
            {
                throw new InvalidDataException("AllianceId is a required property for GetCorporationsCorporationIdAlliancehistoryAlliance and cannot be null");
            }
            else
            {
                this.AllianceId = AllianceId;
            }
            // to ensure "IsDeleted" is required (not null)
            if (IsDeleted == null)
            {
                throw new InvalidDataException("IsDeleted is a required property for GetCorporationsCorporationIdAlliancehistoryAlliance and cannot be null");
            }
            else
            {
                this.IsDeleted = IsDeleted;
            }
        }
        
        /// <summary>
        /// alliance_id integer
        /// </summary>
        /// <value>alliance_id integer</value>
        [DataMember(Name="alliance_id", EmitDefaultValue=false)]
        public int? AllianceId { get; set; }
        /// <summary>
        /// True if the alliance has been deleted
        /// </summary>
        /// <value>True if the alliance has been deleted</value>
        [DataMember(Name="is_deleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdAlliancehistoryAlliance {\n");
            sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(obj as GetCorporationsCorporationIdAlliancehistoryAlliance);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdAlliancehistoryAlliance instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCorporationsCorporationIdAlliancehistoryAlliance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdAlliancehistoryAlliance other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllianceId == other.AllianceId ||
                    this.AllianceId != null &&
                    this.AllianceId.Equals(other.AllianceId)
                ) && 
                (
                    this.IsDeleted == other.IsDeleted ||
                    this.IsDeleted != null &&
                    this.IsDeleted.Equals(other.IsDeleted)
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
                if (this.AllianceId != null)
                    hash = hash * 59 + this.AllianceId.GetHashCode();
                if (this.IsDeleted != null)
                    hash = hash * 59 + this.IsDeleted.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}