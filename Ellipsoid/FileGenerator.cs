using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ellipsoid
{
    public class FileGenerator
    {
        public void GenerateFiles(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int fileNumber = i;
                Thread thread = new Thread(() => WriteToFile(fileNumber));
                thread.Start();
                thread.Join();
            }
        }

        private void WriteToFile(int fileNumber)
        {
            string fileName = $"file{fileNumber}.txt";
            string content = fileNumber.ToString();

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(content);
            }

            Console.WriteLine($"File {fileName} has been generated.");
        }
    }
}
