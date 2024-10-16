using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DriverLincsesSystem.GlobleClasses
{
    public class ClsUtil
    {

        public static string GenerateGUID()
        {
            Guid Generate = Guid.NewGuid();

            return Generate.ToString();
        }

        public static string ReplaceNameFileWithGUID(string SourceFile)
        {
            FileInfo fileInfo = new FileInfo(SourceFile);

            string Ex= fileInfo.Extension;

            return GenerateGUID() + Ex;

        }
        public static bool CheckingIsFileExist(string path)
        {

            bool IsExist = Directory.Exists(path);

            try
            {
                if (!IsExist)
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (IOException io)
            {
                MessageBox.Show($"Error {io}");
                return false;
            }

            return true;
        }
        public static bool CopyImageToFolderX(ref string SourceFile)
        {

            string SourceFolder = @"B:\Driver License\DVL_People_Image\";

            if(!CheckingIsFileExist(SourceFolder)) return false;

               string DestanationFile = SourceFolder + ReplaceNameFileWithGUID(SourceFile);
            try
            {

                File.Copy(SourceFile, DestanationFile,true);
            }
            catch (IOException io)
            {
                MessageBox.Show(io.Message);
                return false;
            }

            SourceFile = DestanationFile;


            return true;
        }

        public static string encrepteData(string LineData)
        {
            string NewString = string.Empty;
            foreach(char c in LineData)
            {
                NewString += Convert.ToChar(c + 15);
            }

            return NewString;
        }

        public static string DecrepteData(string LineData)
        {
            string NewString = string.Empty;
            foreach (char c in LineData)
            {
                NewString += Convert.ToChar(c - 15);
            }

            return NewString;
        }

    }
}
