﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstaSharper.Classes.ResponseWrappers.Extra
{
    internal class InstaExtraResponse
    {
        [JsonExtensionData]
        internal IDictionary<string, JToken> Extras { get; set; }
    }
}
