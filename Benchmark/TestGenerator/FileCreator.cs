using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestGenerator
{
    static class FileCreator
    {
        public static bool TryCreateFile(string fileName, string folder, string content)
        {
            try
            {
                using (var file = File.CreateText(Path.Combine(folder, fileName)))
                {
                    file.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
