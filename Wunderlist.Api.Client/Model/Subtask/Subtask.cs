﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Wunderlist.Api.Client
{

    public class Subtask
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("task_id")]
        public int TaskId { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by_id")]
        public int CreatedById { get; set; }

        [JsonProperty("created_by_request_id")]
        public string CreatedByRequestId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }
    }

}