using System.IO;

namespace File2Folder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"F:\mali\Files", "*.pdf");

            foreach (string filePath in filePaths)
            {
                string directoryPath = Path.GetDirectoryName(filePath);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                string newDirectoryPath = Path.Combine(directoryPath, fileNameWithoutExtension);

                if (!Directory.Exists(newDirectoryPath))
                {
                    Directory.CreateDirectory(newDirectoryPath);
                }

                string newFilePath = Path.Combine(newDirectoryPath, Path.GetFileName(filePath));
                File.Move(filePath, newFilePath);
            }
        }
    }
}
