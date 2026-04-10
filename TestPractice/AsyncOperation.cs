using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkilReview
{
    internal class AsyncOperation
    {
        public async Task<string> ReadFileContentAsync(string filePath)
        {
            return await File.ReadAllTextAsync(filePath);
        }
            string filePath = "path/to/your/file.txt";
        [Test]
        public void TestReadFileContentSync()
        {
            string content = ReadFileContentAsync(filePath).Result; // Blocking call for demonstration
            Console.WriteLine(content);

        }
        [Test]
        public async Task TestReadFileContentAsync()
        {
            string content =await ReadFileContentAsync(filePath); //not blocking call
            Console.WriteLine(content);
        }
    }
}
