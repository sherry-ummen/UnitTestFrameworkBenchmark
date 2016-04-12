using System;
using System.Linq;
using System.Text;

namespace TestGenerator
{
    class TestClassBuilder
    {

        public static string Build(ITestSkeleton skeleton, int numberOfClasses, int numberOfMethodsInEachClass)
        {
            var classAsText = new StringBuilder();
            classAsText.Append(string.Join(Environment.NewLine, skeleton.Usings));
            classAsText.AppendLine();
            classAsText.AppendLine(WrapBlock("namespace", skeleton.Namespace, () => ClassesAndMethods(skeleton, numberOfClasses, numberOfMethodsInEachClass)));
            classAsText.AppendLine();
            return classAsText.ToString();
        }

        private static string ClassesAndMethods(ITestSkeleton skeleton, int numberOfClasses, int numberOfMethods)
        {
            var localBuilder = new StringBuilder();
            foreach (var index in Enumerable.Range(1, numberOfClasses))
            {
                var innerlocalBuilder = new StringBuilder();
                localBuilder.AppendLine(skeleton.ClassAttribute);
                localBuilder.AppendLine(WrapBlock("public class", skeleton.ClassName + index, () => Methods(skeleton, numberOfMethods)));
                localBuilder.AppendLine();
            }
            return localBuilder.ToString();
        }

        private static string Methods(ITestSkeleton skeleton, int numberOfMethods)
        {
            var localBuilder = new StringBuilder();
            foreach (var index in Enumerable.Range(1, numberOfMethods))
            {
                localBuilder.AppendLine(skeleton.MethodAttribute);
                localBuilder.AppendLine(WrapBlock("public void", "Assert" + index + "()", () => string.Join(Environment.NewLine, skeleton.Asserts.ToArray())));
                localBuilder.AppendLine();
            }
            return localBuilder.ToString();
        }

        public static string WrapBlock(string blockType, string blockName, Func<string> block)
        {
            var localBuilder = new StringBuilder();
            localBuilder.AppendFormat("{0} {1} {{", blockType, blockName);
            localBuilder.AppendLine();
            localBuilder.AppendLine(block());
            localBuilder.Append("}");
            return localBuilder.ToString();
        }

    }
}
