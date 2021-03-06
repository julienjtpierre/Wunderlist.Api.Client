﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Wunderlist.Api.Client.TaskCommentJsonTypes;

namespace Wunderlist.Api.Client.TaskCommentJsonTypes
{

    public class Author
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

}

namespace Wunderlist.Api.Client
{

    public class TaskComment
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("task_id")]
        public int TaskId { get; set; }

        [JsonProperty("local_created_at")]
        public string LocalCreatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by_request_id")]
        public string CreatedByRequestId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
