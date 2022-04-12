/*
 * Conductor API Server
 *
 * Conductor API Server
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Conductor.Client.Models
{
    /// <summary>
    /// TaskDef
    /// </summary>
    [DataContract(Name = "TaskDef")]
    public partial class TaskDef : IEquatable<TaskDef>, IValidatableObject
    {
        /// <summary>
        /// Defines TimeoutPolicy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeoutPolicyEnum
        {
            /// <summary>
            /// Enum RETRY for value: RETRY
            /// </summary>
            [EnumMember(Value = "RETRY")]
            RETRY = 1,

            /// <summary>
            /// Enum TIMEOUTWF for value: TIME_OUT_WF
            /// </summary>
            [EnumMember(Value = "TIME_OUT_WF")]
            TIMEOUTWF = 2,

            /// <summary>
            /// Enum ALERTONLY for value: ALERT_ONLY
            /// </summary>
            [EnumMember(Value = "ALERT_ONLY")]
            ALERTONLY = 3

        }


        /// <summary>
        /// Gets or Sets TimeoutPolicy
        /// </summary>
        [DataMember(Name = "timeoutPolicy", EmitDefaultValue = false)]
        public TimeoutPolicyEnum? TimeoutPolicy { get; set; }
        /// <summary>
        /// Defines RetryLogic
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RetryLogicEnum
        {
            /// <summary>
            /// Enum FIXED for value: FIXED
            /// </summary>
            [EnumMember(Value = "FIXED")]
            FIXED = 1,

            /// <summary>
            /// Enum EXPONENTIALBACKOFF for value: EXPONENTIAL_BACKOFF
            /// </summary>
            [EnumMember(Value = "EXPONENTIAL_BACKOFF")]
            EXPONENTIALBACKOFF = 2,

            /// <summary>
            /// Enum LINEARBACKOFF for value: LINEAR_BACKOFF
            /// </summary>
            [EnumMember(Value = "LINEAR_BACKOFF")]
            LINEARBACKOFF = 3

        }


        /// <summary>
        /// Gets or Sets RetryLogic
        /// </summary>
        [DataMember(Name = "retryLogic", EmitDefaultValue = false)]
        public RetryLogicEnum? RetryLogic { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDef" /> class.
        /// </summary>
        [JsonConstructor]
        protected TaskDef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDef" /> class.
        /// </summary>
        /// <param name="ownerApp">ownerApp.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="retryCount">retryCount.</param>
        /// <param name="timeoutSeconds">timeoutSeconds (required).</param>
        /// <param name="inputKeys">inputKeys.</param>
        /// <param name="outputKeys">outputKeys.</param>
        /// <param name="timeoutPolicy">timeoutPolicy.</param>
        /// <param name="retryLogic">retryLogic.</param>
        /// <param name="retryDelaySeconds">retryDelaySeconds.</param>
        /// <param name="responseTimeoutSeconds">responseTimeoutSeconds.</param>
        /// <param name="concurrentExecLimit">concurrentExecLimit.</param>
        /// <param name="inputTemplate">inputTemplate.</param>
        /// <param name="rateLimitPerFrequency">rateLimitPerFrequency.</param>
        /// <param name="rateLimitFrequencyInSeconds">rateLimitFrequencyInSeconds.</param>
        /// <param name="isolationGroupId">isolationGroupId.</param>
        /// <param name="executionNameSpace">executionNameSpace.</param>
        /// <param name="ownerEmail">ownerEmail.</param>
        /// <param name="pollTimeoutSeconds">pollTimeoutSeconds.</param>
        /// <param name="backoffScaleFactor">backoffScaleFactor.</param>
        public TaskDef(string ownerApp = default(string), long createTime = default(long), long updateTime = default(long), string createdBy = default(string), string updatedBy = default(string), string name = default(string), string description = default(string), int retryCount = default(int), long timeoutSeconds = default(long), List<string> inputKeys = default(List<string>), List<string> outputKeys = default(List<string>), TimeoutPolicyEnum? timeoutPolicy = default(TimeoutPolicyEnum?), RetryLogicEnum? retryLogic = default(RetryLogicEnum?), int retryDelaySeconds = default(int), long responseTimeoutSeconds = default(long), int concurrentExecLimit = default(int), Dictionary<string, Object> inputTemplate = default(Dictionary<string, Object>), int rateLimitPerFrequency = default(int), int rateLimitFrequencyInSeconds = default(int), string isolationGroupId = default(string), string executionNameSpace = default(string), string ownerEmail = default(string), int pollTimeoutSeconds = default(int), int backoffScaleFactor = default(int))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for TaskDef and cannot be null");
            }
            this.Name = name;
            this.TimeoutSeconds = timeoutSeconds;
            this.OwnerApp = ownerApp;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.Description = description;
            this.RetryCount = retryCount;
            this.InputKeys = inputKeys;
            this.OutputKeys = outputKeys;
            this.TimeoutPolicy = timeoutPolicy;
            this.RetryLogic = retryLogic;
            this.RetryDelaySeconds = retryDelaySeconds;
            this.ResponseTimeoutSeconds = responseTimeoutSeconds;
            this.ConcurrentExecLimit = concurrentExecLimit;
            this.InputTemplate = inputTemplate;
            this.RateLimitPerFrequency = rateLimitPerFrequency;
            this.RateLimitFrequencyInSeconds = rateLimitFrequencyInSeconds;
            this.IsolationGroupId = isolationGroupId;
            this.ExecutionNameSpace = executionNameSpace;
            this.OwnerEmail = ownerEmail;
            this.PollTimeoutSeconds = pollTimeoutSeconds;
            this.BackoffScaleFactor = backoffScaleFactor;
        }

        /// <summary>
        /// Gets or Sets OwnerApp
        /// </summary>
        [DataMember(Name = "ownerApp", EmitDefaultValue = false)]
        public string OwnerApp { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name = "createTime", EmitDefaultValue = false)]
        public long CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdateTime
        /// </summary>
        [DataMember(Name = "updateTime", EmitDefaultValue = false)]
        public long UpdateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RetryCount
        /// </summary>
        [DataMember(Name = "retryCount", EmitDefaultValue = false)]
        public int RetryCount { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutSeconds
        /// </summary>
        [DataMember(Name = "timeoutSeconds", IsRequired = true, EmitDefaultValue = false)]
        public long TimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or Sets InputKeys
        /// </summary>
        [DataMember(Name = "inputKeys", EmitDefaultValue = false)]
        public List<string> InputKeys { get; set; }

        /// <summary>
        /// Gets or Sets OutputKeys
        /// </summary>
        [DataMember(Name = "outputKeys", EmitDefaultValue = false)]
        public List<string> OutputKeys { get; set; }

        /// <summary>
        /// Gets or Sets RetryDelaySeconds
        /// </summary>
        [DataMember(Name = "retryDelaySeconds", EmitDefaultValue = false)]
        public int RetryDelaySeconds { get; set; }

        /// <summary>
        /// Gets or Sets ResponseTimeoutSeconds
        /// </summary>
        [DataMember(Name = "responseTimeoutSeconds", EmitDefaultValue = false)]
        public long ResponseTimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or Sets ConcurrentExecLimit
        /// </summary>
        [DataMember(Name = "concurrentExecLimit", EmitDefaultValue = false)]
        public int ConcurrentExecLimit { get; set; }

        /// <summary>
        /// Gets or Sets InputTemplate
        /// </summary>
        [DataMember(Name = "inputTemplate", EmitDefaultValue = false)]
        public Dictionary<string, Object> InputTemplate { get; set; }

        /// <summary>
        /// Gets or Sets RateLimitPerFrequency
        /// </summary>
        [DataMember(Name = "rateLimitPerFrequency", EmitDefaultValue = false)]
        public int RateLimitPerFrequency { get; set; }

        /// <summary>
        /// Gets or Sets RateLimitFrequencyInSeconds
        /// </summary>
        [DataMember(Name = "rateLimitFrequencyInSeconds", EmitDefaultValue = false)]
        public int RateLimitFrequencyInSeconds { get; set; }

        /// <summary>
        /// Gets or Sets IsolationGroupId
        /// </summary>
        [DataMember(Name = "isolationGroupId", EmitDefaultValue = false)]
        public string IsolationGroupId { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionNameSpace
        /// </summary>
        [DataMember(Name = "executionNameSpace", EmitDefaultValue = false)]
        public string ExecutionNameSpace { get; set; }

        /// <summary>
        /// Gets or Sets OwnerEmail
        /// </summary>
        [DataMember(Name = "ownerEmail", EmitDefaultValue = false)]
        public string OwnerEmail { get; set; }

        /// <summary>
        /// Gets or Sets PollTimeoutSeconds
        /// </summary>
        [DataMember(Name = "pollTimeoutSeconds", EmitDefaultValue = false)]
        public int PollTimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or Sets BackoffScaleFactor
        /// </summary>
        [DataMember(Name = "backoffScaleFactor", EmitDefaultValue = false)]
        public int BackoffScaleFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaskDef {\n");
            sb.Append("  OwnerApp: ").Append(OwnerApp).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
            sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
            sb.Append("  InputKeys: ").Append(InputKeys).Append("\n");
            sb.Append("  OutputKeys: ").Append(OutputKeys).Append("\n");
            sb.Append("  TimeoutPolicy: ").Append(TimeoutPolicy).Append("\n");
            sb.Append("  RetryLogic: ").Append(RetryLogic).Append("\n");
            sb.Append("  RetryDelaySeconds: ").Append(RetryDelaySeconds).Append("\n");
            sb.Append("  ResponseTimeoutSeconds: ").Append(ResponseTimeoutSeconds).Append("\n");
            sb.Append("  ConcurrentExecLimit: ").Append(ConcurrentExecLimit).Append("\n");
            sb.Append("  InputTemplate: ").Append(InputTemplate).Append("\n");
            sb.Append("  RateLimitPerFrequency: ").Append(RateLimitPerFrequency).Append("\n");
            sb.Append("  RateLimitFrequencyInSeconds: ").Append(RateLimitFrequencyInSeconds).Append("\n");
            sb.Append("  IsolationGroupId: ").Append(IsolationGroupId).Append("\n");
            sb.Append("  ExecutionNameSpace: ").Append(ExecutionNameSpace).Append("\n");
            sb.Append("  OwnerEmail: ").Append(OwnerEmail).Append("\n");
            sb.Append("  PollTimeoutSeconds: ").Append(PollTimeoutSeconds).Append("\n");
            sb.Append("  BackoffScaleFactor: ").Append(BackoffScaleFactor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskDef);
        }

        /// <summary>
        /// Returns true if TaskDef instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskDef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskDef input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OwnerApp == input.OwnerApp ||
                    (this.OwnerApp != null &&
                    this.OwnerApp.Equals(input.OwnerApp))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    this.UpdateTime.Equals(input.UpdateTime)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RetryCount == input.RetryCount ||
                    this.RetryCount.Equals(input.RetryCount)
                ) && 
                (
                    this.TimeoutSeconds == input.TimeoutSeconds ||
                    this.TimeoutSeconds.Equals(input.TimeoutSeconds)
                ) && 
                (
                    this.InputKeys == input.InputKeys ||
                    this.InputKeys != null &&
                    input.InputKeys != null &&
                    this.InputKeys.SequenceEqual(input.InputKeys)
                ) && 
                (
                    this.OutputKeys == input.OutputKeys ||
                    this.OutputKeys != null &&
                    input.OutputKeys != null &&
                    this.OutputKeys.SequenceEqual(input.OutputKeys)
                ) && 
                (
                    this.TimeoutPolicy == input.TimeoutPolicy ||
                    this.TimeoutPolicy.Equals(input.TimeoutPolicy)
                ) && 
                (
                    this.RetryLogic == input.RetryLogic ||
                    this.RetryLogic.Equals(input.RetryLogic)
                ) && 
                (
                    this.RetryDelaySeconds == input.RetryDelaySeconds ||
                    this.RetryDelaySeconds.Equals(input.RetryDelaySeconds)
                ) && 
                (
                    this.ResponseTimeoutSeconds == input.ResponseTimeoutSeconds ||
                    this.ResponseTimeoutSeconds.Equals(input.ResponseTimeoutSeconds)
                ) && 
                (
                    this.ConcurrentExecLimit == input.ConcurrentExecLimit ||
                    this.ConcurrentExecLimit.Equals(input.ConcurrentExecLimit)
                ) && 
                (
                    this.InputTemplate == input.InputTemplate ||
                    this.InputTemplate != null &&
                    input.InputTemplate != null &&
                    this.InputTemplate.SequenceEqual(input.InputTemplate)
                ) && 
                (
                    this.RateLimitPerFrequency == input.RateLimitPerFrequency ||
                    this.RateLimitPerFrequency.Equals(input.RateLimitPerFrequency)
                ) && 
                (
                    this.RateLimitFrequencyInSeconds == input.RateLimitFrequencyInSeconds ||
                    this.RateLimitFrequencyInSeconds.Equals(input.RateLimitFrequencyInSeconds)
                ) && 
                (
                    this.IsolationGroupId == input.IsolationGroupId ||
                    (this.IsolationGroupId != null &&
                    this.IsolationGroupId.Equals(input.IsolationGroupId))
                ) && 
                (
                    this.ExecutionNameSpace == input.ExecutionNameSpace ||
                    (this.ExecutionNameSpace != null &&
                    this.ExecutionNameSpace.Equals(input.ExecutionNameSpace))
                ) && 
                (
                    this.OwnerEmail == input.OwnerEmail ||
                    (this.OwnerEmail != null &&
                    this.OwnerEmail.Equals(input.OwnerEmail))
                ) && 
                (
                    this.PollTimeoutSeconds == input.PollTimeoutSeconds ||
                    this.PollTimeoutSeconds.Equals(input.PollTimeoutSeconds)
                ) && 
                (
                    this.BackoffScaleFactor == input.BackoffScaleFactor ||
                    this.BackoffScaleFactor.Equals(input.BackoffScaleFactor)
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
                if (this.OwnerApp != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerApp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdateTime.GetHashCode();
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RetryCount.GetHashCode();
                hashCode = (hashCode * 59) + this.TimeoutSeconds.GetHashCode();
                if (this.InputKeys != null)
                {
                    hashCode = (hashCode * 59) + this.InputKeys.GetHashCode();
                }
                if (this.OutputKeys != null)
                {
                    hashCode = (hashCode * 59) + this.OutputKeys.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TimeoutPolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.RetryLogic.GetHashCode();
                hashCode = (hashCode * 59) + this.RetryDelaySeconds.GetHashCode();
                hashCode = (hashCode * 59) + this.ResponseTimeoutSeconds.GetHashCode();
                hashCode = (hashCode * 59) + this.ConcurrentExecLimit.GetHashCode();
                if (this.InputTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.InputTemplate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RateLimitPerFrequency.GetHashCode();
                hashCode = (hashCode * 59) + this.RateLimitFrequencyInSeconds.GetHashCode();
                if (this.IsolationGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.IsolationGroupId.GetHashCode();
                }
                if (this.ExecutionNameSpace != null)
                {
                    hashCode = (hashCode * 59) + this.ExecutionNameSpace.GetHashCode();
                }
                if (this.OwnerEmail != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerEmail.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PollTimeoutSeconds.GetHashCode();
                hashCode = (hashCode * 59) + this.BackoffScaleFactor.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // RetryCount (int) minimum
            if (this.RetryCount < (int)0)
            {
                yield return new ValidationResult("Invalid value for RetryCount, must be a value greater than or equal to 0.", new [] { "RetryCount" });
            }

            // ResponseTimeoutSeconds (long) minimum
            if (this.ResponseTimeoutSeconds < (long)1)
            {
                yield return new ValidationResult("Invalid value for ResponseTimeoutSeconds, must be a value greater than or equal to 1.", new [] { "ResponseTimeoutSeconds" });
            }

            // PollTimeoutSeconds (int) minimum
            if (this.PollTimeoutSeconds < (int)0)
            {
                yield return new ValidationResult("Invalid value for PollTimeoutSeconds, must be a value greater than or equal to 0.", new [] { "PollTimeoutSeconds" });
            }

            // BackoffScaleFactor (int) minimum
            if (this.BackoffScaleFactor < (int)1)
            {
                yield return new ValidationResult("Invalid value for BackoffScaleFactor, must be a value greater than or equal to 1.", new [] { "BackoffScaleFactor" });
            }

            yield break;
        }
    }

}
