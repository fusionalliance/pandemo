using System;
using System.Runtime.Serialization;

namespace Client.Library.PublicAPI.External.Models
{
    [DataContract]
    public class WebNotification
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Topic { get; set; }
        [DataMember]
        public bool IsHighPriority { get; set; }
        [DataMember]
        public DateTime IssuedOn { get; set; }
    }
}