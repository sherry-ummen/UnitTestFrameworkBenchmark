using System.Collections.Generic;

namespace TestGenerator
{
    class MSTestTest : ITestSkeleton
    {
        public MSTestTest()
        {
            Usings = new List<string>()
            {
                "using Microsoft.VisualStudio.TestTools.UnitTesting;"
            };
            Namespace = "MStest";
            ClassName = "MSTestPerformanceTest";
            ClassAttribute = "[TestClass]";
            MethodAttribute = "[TestMethod]";
            Asserts = new List<string>
            {
                "Assert.IsTrue( true );"
            };
        }

        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public List<string> Usings { get; set; }
        public string MethodAttribute { get; set; }
        public string ClassAttribute { get; set; }
        public List<string> Asserts { get; set; }

    }
}
