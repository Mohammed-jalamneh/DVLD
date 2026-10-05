using System;
using System.IO;

namespace DVLD
{
    public class clsUtil
    {
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }

        public static string ReplaceFileNameWithGUID(string FileName)
        {
            FileInfo F = new FileInfo(FileName);
            return GenerateGUID() + F.Extension;
        }

        public static bool CopyImageToProjectImagesFolder(ref string picSource)
        {
            if (string.IsNullOrWhiteSpace(picSource))
            {
                return false;
            }

            string DesFolder = @"C:\DVLDpictures\DVLD - People - Pictures\";

            if (picSource.StartsWith(DesFolder, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (!CreateFolderIfDoesNotExist(DesFolder))
            {
                return false;
            }

            string DesFile = DesFolder + ReplaceFileNameWithGUID(picSource);

            try
            {
                File.Copy(picSource, DesFile, true);
            }
            catch (Exception) 
            {
                return false;
            }

            picSource = DesFile;

            return true;
        }
    }
}