using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.Xml;

namespace SimpleSerialize;

public class JamesBondCar : Car
{
    [JsonInclude]
    public bool CanFly;
    [JsonInclude]
    public bool CanSubmerge;
    public override string ToString() => $"CanFly: {CanFly}, CanSubmerge: {CanSubmerge} {base.ToString()}";
}
