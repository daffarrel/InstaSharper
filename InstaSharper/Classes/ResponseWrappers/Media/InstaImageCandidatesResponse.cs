﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstaSharper.Classes.ResponseWrappers.Media
{
    public class InstaImageCandidatesResponse
    {
        [JsonProperty("candidates")] public List<BaseMediaResponse> Candidates { get; set; }
    }
}