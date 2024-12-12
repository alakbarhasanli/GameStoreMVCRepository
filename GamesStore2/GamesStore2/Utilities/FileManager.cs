using System.IO;

namespace GamesStore2.Utilities
{
    public static class FileManager
    {
        public static bool Checktype(this IFormFile formFile) => formFile.ContentType.Contains("image");
        public static bool CheckSize(this IFormFile formFile, int size)
        {
            if (formFile.Length > size * 1024 * 1024)
            {
                return false;
            }
            return true;
        }
        public static string UploadImage(this IFormFile formFile, string envpath, string folder)
        {
            string path = envpath + folder;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filename = Path.GetFileNameWithoutExtension(formFile.FileName);
            if (filename.Length > 50)
            {
                filename.Substring(0, 79);
            }
            filename = Guid.NewGuid().ToString() + formFile.FileName + Path.GetExtension(formFile.FileName);
            using (FileStream fileStream = new FileStream(path + filename, FileMode.Create))
            {
                formFile.CopyTo(fileStream);
            }

            return filename;
        }
    }
}
