using System;
using System.Collections.Generic;
using System.Text;

namespace AutoLot.Samples.Models;

public class Radio : BaseEntity
{
    public bool HasTweeters { get; set; }
    public bool HasSubWoofers { get; set; }
    public string? RadioId { get; set; }
    public int CArId { get; set; }
    public Car CarNavigation { get; set; }
}
