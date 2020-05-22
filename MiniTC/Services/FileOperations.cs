using System.Diagnostics;
using System.IO;
using System.Windows;

namespace MiniTC.Services
{
    class FileOperations
    {
        public static void Copy(string fileName, string sourcePath, string destinationPath)
        {
            if (fileName == null)
                return;

            //kopiowanie katalogu
            if (fileName.Contains("<D>"))
            {
                var dirName = fileName.Substring(3);
                var source = new DirectoryInfo(sourcePath + dirName);
                var destination = new DirectoryInfo(destinationPath + @"\" + dirName);

                // kopiowanie folderu do samego siebie uniemożliwienie
                if (destinationPath.Contains(source.ToString()))
                {
                    MessageBox.Show(Resources.Resources.ErrorMessageCopyToSelf);
                    return;
                }

                try
                {
                    CopyDir(source, destination);
                }
                catch
                {
                    MessageBox.Show(Resources.Resources.ErrorMessageCopyDir
                        + "\n problem ze skopiowaniem zawartości folderu, gdy ścieżka jest dłuższa niż DRIVE:FOLDER");
                }
            }
            //kopiowanie pliku
            else
            {
                var source = Path.Combine(sourcePath, fileName);
                var destination = Path.Combine(destinationPath, fileName);
                try
                {
                    File.Copy(source, destination, true);
                }
                catch
                {
                    MessageBox.Show(Resources.Resources.ErrorMessageCopyFile);
                }
            }
        }

        private static void CopyDir(DirectoryInfo source, DirectoryInfo destination)
        {
            Directory.CreateDirectory(destination.FullName);

            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(destination.FullName, fi.Name), true);
            }

            foreach (DirectoryInfo dirSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = destination.CreateSubdirectory(dirSourceSubDir.Name);
                CopyDir(dirSourceSubDir, nextTargetSubDir);
            }
        }
    }
}