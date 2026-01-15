using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.Xml;

namespace SimpleSerialize;

public class Car
{
    [JsonInclude]
    public Radio TheRadio = new Radio();
    [JsonInclude]
    public bool IsHatchBack;
    public override string ToString() => $"IsHatchback: {IsHatchBack} Radio Info: {TheRadio}";
}
