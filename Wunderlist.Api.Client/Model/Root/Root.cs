﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Wunderlist.Api.Client
{

    public class Root
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }

}
