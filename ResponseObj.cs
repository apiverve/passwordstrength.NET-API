using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class passwordInfo
{
    [JsonProperty("length")]
    public int length { get; set; }

    [JsonProperty("hasSpecialCharacters")]
    public bool hasSpecialCharacters { get; set; }

    [JsonProperty("hasNumbers")]
    public bool hasNumbers { get; set; }

    [JsonProperty("hasLowercase")]
    public bool hasLowercase { get; set; }

    [JsonProperty("hasUppercase")]
    public bool hasUppercase { get; set; }

    [JsonProperty("hasSpaces")]
    public bool hasSpaces { get; set; }

}

public class data
{
    [JsonProperty("strength")]
    public string strength { get; set; }

    [JsonProperty("passwordInfo")]
    public passwordInfo passwordInfo { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
