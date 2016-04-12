using System.Collections.Generic;

namespace TestGenerator
{
    class XUnitTest : ITestSkeleton
    {
        public XUnitTest()
        {
            Usings = new List<string>()
            {
                "using Xunit;"
            };
            Namespace = "XUnit";
            ClassName = "XUnitPerformanceTest";
            ClassAttribute = "";
            MethodAttribute = "[Fact]";
            Asserts = new List<string>
            {
                "Assert.True( true );"
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
