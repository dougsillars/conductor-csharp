/* 
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Conductor.Client.Models
{
    /// <summary>
    /// UninterpretedOptionOrBuilder
    /// </summary>
    [DataContract]
    public partial class UninterpretedOptionOrBuilder :  IEquatable<UninterpretedOptionOrBuilder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UninterpretedOptionOrBuilder" /> class.
        /// </summary>
        /// <param name="doubleValue">doubleValue.</param>
        /// <param name="stringValue">stringValue.</param>
        /// <param name="nameList">nameList.</param>
        /// <param name="nameOrBuilderList">nameOrBuilderList.</param>
        /// <param name="identifierValue">identifierValue.</param>
        /// <param name="identifierValueBytes">identifierValueBytes.</param>
        /// <param name="positiveIntValue">positiveIntValue.</param>
        /// <param name="negativeIntValue">negativeIntValue.</param>
        /// <param name="aggregateValue">aggregateValue.</param>
        /// <param name="aggregateValueBytes">aggregateValueBytes.</param>
        /// <param name="nameCount">nameCount.</param>
        /// <param name="defaultInstanceForType">defaultInstanceForType.</param>
        /// <param name="initializationErrorString">initializationErrorString.</param>
        /// <param name="descriptorForType">descriptorForType.</param>
        /// <param name="allFields">allFields.</param>
        /// <param name="unknownFields">unknownFields.</param>
        /// <param name="initialized">initialized (default to false).</param>
        public UninterpretedOptionOrBuilder(double? doubleValue = default(double?), ByteString stringValue = default(ByteString), List<NamePart> nameList = default(List<NamePart>), List<NamePartOrBuilder> nameOrBuilderList = default(List<NamePartOrBuilder>), string identifierValue = default(string), ByteString identifierValueBytes = default(ByteString), long? positiveIntValue = default(long?), long? negativeIntValue = default(long?), string aggregateValue = default(string), ByteString aggregateValueBytes = default(ByteString), int? nameCount = default(int?), Message defaultInstanceForType = default(Message), string initializationErrorString = default(string), Descriptor descriptorForType = default(Descriptor), Dictionary<string, Object> allFields = default(Dictionary<string, Object>), UnknownFieldSet unknownFields = default(UnknownFieldSet), bool? initialized = false)
        {
            this.DoubleValue = doubleValue;
            this.StringValue = stringValue;
            this.NameList = nameList;
            this.NameOrBuilderList = nameOrBuilderList;
            this.IdentifierValue = identifierValue;
            this.IdentifierValueBytes = identifierValueBytes;
            this.PositiveIntValue = positiveIntValue;
            this.NegativeIntValue = negativeIntValue;
            this.AggregateValue = aggregateValue;
            this.AggregateValueBytes = aggregateValueBytes;
            this.NameCount = nameCount;
            this.DefaultInstanceForType = defaultInstanceForType;
            this.InitializationErrorString = initializationErrorString;
            this.DescriptorForType = descriptorForType;
            this.AllFields = allFields;
            this.UnknownFields = unknownFields;
            // use default value if no "initialized" provided
            if (initialized == null)
            {
                this.Initialized = false;
            }
            else
            {
                this.Initialized = initialized;
            }
        }
        
        /// <summary>
        /// Gets or Sets DoubleValue
        /// </summary>
        [DataMember(Name="doubleValue", EmitDefaultValue=false)]
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Gets or Sets StringValue
        /// </summary>
        [DataMember(Name="stringValue", EmitDefaultValue=false)]
        public ByteString StringValue { get; set; }

        /// <summary>
        /// Gets or Sets NameList
        /// </summary>
        [DataMember(Name="nameList", EmitDefaultValue=false)]
        public List<NamePart> NameList { get; set; }

        /// <summary>
        /// Gets or Sets NameOrBuilderList
        /// </summary>
        [DataMember(Name="nameOrBuilderList", EmitDefaultValue=false)]
        public List<NamePartOrBuilder> NameOrBuilderList { get; set; }

        /// <summary>
        /// Gets or Sets IdentifierValue
        /// </summary>
        [DataMember(Name="identifierValue", EmitDefaultValue=false)]
        public string IdentifierValue { get; set; }

        /// <summary>
        /// Gets or Sets IdentifierValueBytes
        /// </summary>
        [DataMember(Name="identifierValueBytes", EmitDefaultValue=false)]
        public ByteString IdentifierValueBytes { get; set; }

        /// <summary>
        /// Gets or Sets PositiveIntValue
        /// </summary>
        [DataMember(Name="positiveIntValue", EmitDefaultValue=false)]
        public long? PositiveIntValue { get; set; }

        /// <summary>
        /// Gets or Sets NegativeIntValue
        /// </summary>
        [DataMember(Name="negativeIntValue", EmitDefaultValue=false)]
        public long? NegativeIntValue { get; set; }

        /// <summary>
        /// Gets or Sets AggregateValue
        /// </summary>
        [DataMember(Name="aggregateValue", EmitDefaultValue=false)]
        public string AggregateValue { get; set; }

        /// <summary>
        /// Gets or Sets AggregateValueBytes
        /// </summary>
        [DataMember(Name="aggregateValueBytes", EmitDefaultValue=false)]
        public ByteString AggregateValueBytes { get; set; }

        /// <summary>
        /// Gets or Sets NameCount
        /// </summary>
        [DataMember(Name="nameCount", EmitDefaultValue=false)]
        public int? NameCount { get; set; }

        /// <summary>
        /// Gets or Sets DefaultInstanceForType
        /// </summary>
        [DataMember(Name="defaultInstanceForType", EmitDefaultValue=false)]
        public Message DefaultInstanceForType { get; set; }

        /// <summary>
        /// Gets or Sets InitializationErrorString
        /// </summary>
        [DataMember(Name="initializationErrorString", EmitDefaultValue=false)]
        public string InitializationErrorString { get; set; }

        /// <summary>
        /// Gets or Sets DescriptorForType
        /// </summary>
        [DataMember(Name="descriptorForType", EmitDefaultValue=false)]
        public Descriptor DescriptorForType { get; set; }

        /// <summary>
        /// Gets or Sets AllFields
        /// </summary>
        [DataMember(Name="allFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> AllFields { get; set; }

        /// <summary>
        /// Gets or Sets UnknownFields
        /// </summary>
        [DataMember(Name="unknownFields", EmitDefaultValue=false)]
        public UnknownFieldSet UnknownFields { get; set; }

        /// <summary>
        /// Gets or Sets Initialized
        /// </summary>
        [DataMember(Name="initialized", EmitDefaultValue=false)]
        public bool? Initialized { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UninterpretedOptionOrBuilder {\n");
            sb.Append("  DoubleValue: ").Append(DoubleValue).Append("\n");
            sb.Append("  StringValue: ").Append(StringValue).Append("\n");
            sb.Append("  NameList: ").Append(NameList).Append("\n");
            sb.Append("  NameOrBuilderList: ").Append(NameOrBuilderList).Append("\n");
            sb.Append("  IdentifierValue: ").Append(IdentifierValue).Append("\n");
            sb.Append("  IdentifierValueBytes: ").Append(IdentifierValueBytes).Append("\n");
            sb.Append("  PositiveIntValue: ").Append(PositiveIntValue).Append("\n");
            sb.Append("  NegativeIntValue: ").Append(NegativeIntValue).Append("\n");
            sb.Append("  AggregateValue: ").Append(AggregateValue).Append("\n");
            sb.Append("  AggregateValueBytes: ").Append(AggregateValueBytes).Append("\n");
            sb.Append("  NameCount: ").Append(NameCount).Append("\n");
            sb.Append("  DefaultInstanceForType: ").Append(DefaultInstanceForType).Append("\n");
            sb.Append("  InitializationErrorString: ").Append(InitializationErrorString).Append("\n");
            sb.Append("  DescriptorForType: ").Append(DescriptorForType).Append("\n");
            sb.Append("  AllFields: ").Append(AllFields).Append("\n");
            sb.Append("  UnknownFields: ").Append(UnknownFields).Append("\n");
            sb.Append("  Initialized: ").Append(Initialized).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UninterpretedOptionOrBuilder);
        }

        /// <summary>
        /// Returns true if UninterpretedOptionOrBuilder instances are equal
        /// </summary>
        /// <param name="input">Instance of UninterpretedOptionOrBuilder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UninterpretedOptionOrBuilder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DoubleValue == input.DoubleValue ||
                    (this.DoubleValue != null &&
                    this.DoubleValue.Equals(input.DoubleValue))
                ) && 
                (
                    this.StringValue == input.StringValue ||
                    (this.StringValue != null &&
                    this.StringValue.Equals(input.StringValue))
                ) && 
                (
                    this.NameList == input.NameList ||
                    this.NameList != null &&
                    this.NameList.SequenceEqual(input.NameList)
                ) && 
                (
                    this.NameOrBuilderList == input.NameOrBuilderList ||
                    this.NameOrBuilderList != null &&
                    this.NameOrBuilderList.SequenceEqual(input.NameOrBuilderList)
                ) && 
                (
                    this.IdentifierValue == input.IdentifierValue ||
                    (this.IdentifierValue != null &&
                    this.IdentifierValue.Equals(input.IdentifierValue))
                ) && 
                (
                    this.IdentifierValueBytes == input.IdentifierValueBytes ||
                    (this.IdentifierValueBytes != null &&
                    this.IdentifierValueBytes.Equals(input.IdentifierValueBytes))
                ) && 
                (
                    this.PositiveIntValue == input.PositiveIntValue ||
                    (this.PositiveIntValue != null &&
                    this.PositiveIntValue.Equals(input.PositiveIntValue))
                ) && 
                (
                    this.NegativeIntValue == input.NegativeIntValue ||
                    (this.NegativeIntValue != null &&
                    this.NegativeIntValue.Equals(input.NegativeIntValue))
                ) && 
                (
                    this.AggregateValue == input.AggregateValue ||
                    (this.AggregateValue != null &&
                    this.AggregateValue.Equals(input.AggregateValue))
                ) && 
                (
                    this.AggregateValueBytes == input.AggregateValueBytes ||
                    (this.AggregateValueBytes != null &&
                    this.AggregateValueBytes.Equals(input.AggregateValueBytes))
                ) && 
                (
                    this.NameCount == input.NameCount ||
                    (this.NameCount != null &&
                    this.NameCount.Equals(input.NameCount))
                ) && 
                (
                    this.DefaultInstanceForType == input.DefaultInstanceForType ||
                    (this.DefaultInstanceForType != null &&
                    this.DefaultInstanceForType.Equals(input.DefaultInstanceForType))
                ) && 
                (
                    this.InitializationErrorString == input.InitializationErrorString ||
                    (this.InitializationErrorString != null &&
                    this.InitializationErrorString.Equals(input.InitializationErrorString))
                ) && 
                (
                    this.DescriptorForType == input.DescriptorForType ||
                    (this.DescriptorForType != null &&
                    this.DescriptorForType.Equals(input.DescriptorForType))
                ) && 
                (
                    this.AllFields == input.AllFields ||
                    this.AllFields != null &&
                    this.AllFields.SequenceEqual(input.AllFields)
                ) && 
                (
                    this.UnknownFields == input.UnknownFields ||
                    (this.UnknownFields != null &&
                    this.UnknownFields.Equals(input.UnknownFields))
                ) && 
                (
                    this.Initialized == input.Initialized ||
                    (this.Initialized != null &&
                    this.Initialized.Equals(input.Initialized))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DoubleValue != null)
                    hashCode = hashCode * 59 + this.DoubleValue.GetHashCode();
                if (this.StringValue != null)
                    hashCode = hashCode * 59 + this.StringValue.GetHashCode();
                if (this.NameList != null)
                    hashCode = hashCode * 59 + this.NameList.GetHashCode();
                if (this.NameOrBuilderList != null)
                    hashCode = hashCode * 59 + this.NameOrBuilderList.GetHashCode();
                if (this.IdentifierValue != null)
                    hashCode = hashCode * 59 + this.IdentifierValue.GetHashCode();
                if (this.IdentifierValueBytes != null)
                    hashCode = hashCode * 59 + this.IdentifierValueBytes.GetHashCode();
                if (this.PositiveIntValue != null)
                    hashCode = hashCode * 59 + this.PositiveIntValue.GetHashCode();
                if (this.NegativeIntValue != null)
                    hashCode = hashCode * 59 + this.NegativeIntValue.GetHashCode();
                if (this.AggregateValue != null)
                    hashCode = hashCode * 59 + this.AggregateValue.GetHashCode();
                if (this.AggregateValueBytes != null)
                    hashCode = hashCode * 59 + this.AggregateValueBytes.GetHashCode();
                if (this.NameCount != null)
                    hashCode = hashCode * 59 + this.NameCount.GetHashCode();
                if (this.DefaultInstanceForType != null)
                    hashCode = hashCode * 59 + this.DefaultInstanceForType.GetHashCode();
                if (this.InitializationErrorString != null)
                    hashCode = hashCode * 59 + this.InitializationErrorString.GetHashCode();
                if (this.DescriptorForType != null)
                    hashCode = hashCode * 59 + this.DescriptorForType.GetHashCode();
                if (this.AllFields != null)
                    hashCode = hashCode * 59 + this.AllFields.GetHashCode();
                if (this.UnknownFields != null)
                    hashCode = hashCode * 59 + this.UnknownFields.GetHashCode();
                if (this.Initialized != null)
                    hashCode = hashCode * 59 + this.Initialized.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
