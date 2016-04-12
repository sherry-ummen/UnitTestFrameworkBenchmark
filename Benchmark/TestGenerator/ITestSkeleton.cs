using System.Collections.Generic;

namespace TestGenerator
{
    public interface ITestSkeleton
    {
        string Namespace { get; }
        string ClassName { get; }
        List<string> Usings { get; }
        string MethodAttribute { get; }
        string ClassAttribute { get; }
        List<string> Asserts { get; }
    }
}
