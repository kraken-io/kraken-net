﻿using System;
using Newtonsoft.Json;

namespace Kraken.Model.S3
{
    public class OptimizeSetWaitRequest : Model.OptimizeSetWaitRequest
    {
        public OptimizeSetWaitRequest(Uri imageUrl, DataStore dataStore) : base(imageUrl)
        {
            S3Store = dataStore;
        }

        [JsonProperty("s3_store")]
        public DataStore S3Store { get; internal set; }
    }
}
