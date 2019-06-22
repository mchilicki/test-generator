using System;
using System.Collections.Generic;
using System.Linq;

namespace TestGenerator.UserInterface.Models
{
    public class TestQuestion
    {
        public string Question { get; set; }
        public ICollection<string> Answers { get; set; } = new List<string>();
    }
}
