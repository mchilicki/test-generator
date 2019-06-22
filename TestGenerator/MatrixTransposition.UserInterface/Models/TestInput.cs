using System;
using System.Collections.Generic;
using System.Linq;

namespace TestGenerator.UserInterface.Models
{
    public class TestInput
    {
        public IEnumerable<TestQuestion> TestQuestions { get; set; }
    }
}
