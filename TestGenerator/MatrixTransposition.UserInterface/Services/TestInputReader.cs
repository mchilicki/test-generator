using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TestGenerator.UserInterface.Models;

namespace TestGenerator.UserInterface.Services
{
    public class TestInputReader
    {
        public TestInput LoadTestInput(string fileName)
        {
            var fileLines = File.ReadAllLines(fileName).ToList();
            var testQuestions = new List<TestQuestion>();
            var currentTestQuestion = new TestQuestion();
            foreach(var fileLine in fileLines)
            {
                if (string.IsNullOrWhiteSpace(fileLine))
                {
                    testQuestions.Add(currentTestQuestion);
                    currentTestQuestion = new TestQuestion();
                    continue;
                }
                if (string.IsNullOrWhiteSpace(currentTestQuestion.Question))
                {
                    currentTestQuestion.Question = fileLine;
                    continue;
                }
                currentTestQuestion.Answers.Add(fileLine);
            }
            return new TestInput()
            {
                TestQuestions = testQuestions,
            };
        }
    }
}
