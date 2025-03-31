using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Assignments
{
    internal class Assignment5
    {
        public void TextFileOperations()
        {
            string filePath = "sample.txt";

            // Writing to a text file
            File.WriteAllText(filePath, "This is the first line of text.\n");

            // Appending to the text file
            File.AppendAllText(filePath, "Appending a second line of text.\n");

            // Reading from the text file
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content:\n" + content);
        }

        public void BinaryFileOperations()
        {
            
                string filePath = "binarydata.dat";

                // Writing to a binary file
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    writer.Write(42); // Writing an integer
                    writer.Write("Hello, Binary World!"); // Writing a string
                }

                // Reading from a binary file
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    int number = reader.ReadInt32();
                    string text = reader.ReadString();
                    Console.WriteLine($"Read Data: {number}, {text}");
                }
            }


        public void DirectoryAndFileInfoDemo()
        {
          
                string directoryPath = "."; // Current directory

                // Get directory info
                DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
                Console.WriteLine("Directory Info:");
                Console.WriteLine($"Full Name: {dirInfo.FullName}");
                Console.WriteLine($"Created On: {dirInfo.CreationTime}");
                Console.WriteLine();

                // Get file info
                FileInfo[] files = dirInfo.GetFiles();
                Console.WriteLine("Files in Directory:");
                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"File Name: {file.Name}, Size: {file.Length} bytes, Created On: {file.CreationTime}");
                }
            }

        public void TestAssignment5()
        {
            Console.WriteLine("Testing Text File Operations...");
            string textFilePath = "sample.txt";

            // Writing to a text file
            File.WriteAllText(textFilePath, "This is the first line of text.\n");
            // Appending to the text file
            File.AppendAllText(textFilePath, "Appending a second line of text.\n");
            // Reading from the text file
            string textContent = File.ReadAllText(textFilePath);
            Console.WriteLine("Text File Content:\n" + textContent);

            Console.WriteLine("\nTesting Binary File Operations...");
            string binaryFilePath = "binarydata.dat";

            // Writing to a binary file
            using (BinaryWriter writer = new BinaryWriter(File.Open(binaryFilePath, FileMode.Create)))
            {
                writer.Write(42); // Writing an integer
                writer.Write("Hello, Binary World!"); // Writing a string
            }

            // Reading from a binary file
            using (BinaryReader reader = new BinaryReader(File.Open(binaryFilePath, FileMode.Open)))
            {
                int number = reader.ReadInt32();
                string text = reader.ReadString();
                Console.WriteLine($"Read Binary Data: {number}, {text}");
            }

            Console.WriteLine("\nTesting Directory and File Info Operations...");
            string directoryPath = "."; // Current directory

            // Get directory info
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
            Console.WriteLine("Directory Info:");
            Console.WriteLine($"Full Name: {dirInfo.FullName}");
            Console.WriteLine($"Created On: {dirInfo.CreationTime}");

            // Get file info
            FileInfo[] files = dirInfo.GetFiles();
            Console.WriteLine("Files in Directory:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"File Name: {file.Name}, Size: {file.Length} bytes, Created On: {file.CreationTime}");
            }
        }
    }
}

