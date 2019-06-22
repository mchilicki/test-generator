using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.UserInterface.Models
{
    public class Settings
    {
        public string MatrixFileName { get; set; }
        public int MatrixGenerateFrom { get; } = 1;
        public int MatrixGenerateTo { get; } = 10;
    }
}
