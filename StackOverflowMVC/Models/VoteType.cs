using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace StackOverflowMVC.Models
{
    [Index(nameof(Name))]
    public class VoteType
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
    }
}
