using System.Collections.Generic;

namespace TestGenerator
{
    class NUnitTest : ITestSkeleton
    {
        public NUnitTest()
        {
            Usings = new List<string>()
            {
                "using NUnit.Framework;"
            };
            Namespace = "NUnit";
            ClassName = "NUnitPerformanceTest";
            ClassAttribute = "[TestFixture]";
            MethodAttribute = "[Test]";
            Asserts = new List<string>
            {
                " Assert.That( true );"
            };
        }
        public string Namespace { get; }
        public string ClassName { get; }
        public List<string> Usings { get; }
        public string MethodAttribute { get; }
        public string ClassAttribute { get; }
        public List<string> Asserts { get; }
    }
}
