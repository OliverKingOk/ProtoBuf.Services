﻿using System;
using System.Runtime.Serialization;

namespace ProtoBuf.Wcf.Tests.Models
{
    [DataContract]
    public class TestModelSimple
    {
        [DataMember]
        public string TestProperty1 { get; set; }

        [DataMember]
        public int TestProperty2 { get; set; }

        [DataMember]
        public DateTime OtherFieldInfo;
        
        [DataMember]
        public TestEnum TestEnum { get; set; }
    }

    [DataContract]
    public enum TestEnum
    {
        [EnumMember]
        Nothing = 0,
        [EnumMember]
        Something = 1,
        Secret = 2
    }
}