using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.Xml;

namespace SimpleSerialize;

public class Person
{
    [JsonInclude]
    public bool IsAlive = true;
    private int PersonAge = 21;
    private string _fName = string.Empty;
    public string FirstName
    {
        get { return _fName; }
        set { _fName = value; }
    }
    public override string ToString() => $"IsAlive: {IsAlive} FirstName: {FirstName} Age: {PersonAge}";
}
