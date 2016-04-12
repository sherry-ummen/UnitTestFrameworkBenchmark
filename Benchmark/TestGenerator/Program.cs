using System;
using System.IO;

namespace TestGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseDir = Directory.
                GetParent(AppDomain.CurrentDomain.BaseDirectory).
                Parent.Parent.Parent.FullName; //Ugly hack. 

            //NUnit
            var nunitFolderPath = Path.Combine(baseDir.ToString(), "NUnit");
            FileCreator.TryCreateFile("NUnitTest.cs",
                nunitFolderPath,
                TestClassBuilder.Build(new NUnitTest(),
                numberOfClasses: 10,
                numberOfMethodsInEachClass: 200));

            //XUnit
            var xunitFolderPath = Path.Combine(baseDir.ToString(), "Benchmark");
            FileCreator.TryCreateFile("XUnitTest.cs",
                xunitFolderPath,
                TestClassBuilder.Build(new XUnitTest(),
                numberOfClasses: 10,
                numberOfMethodsInEachClass: 200));

            //MSTest
            var mstestFolderPath = Path.Combine(baseDir.ToString(), "MSTest");
            FileCreator.TryCreateFile("MSTestTest.cs",
                mstestFolderPath,
                TestClassBuilder.Build(new MSTestTest(),
                numberOfClasses: 10,
                numberOfMethodsInEachClass: 200));

        }
    }
}
