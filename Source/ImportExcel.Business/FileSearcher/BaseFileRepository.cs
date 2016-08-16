using System.IO;
using System.Linq;

namespace ImportExcel.Business.FileSearcher
{
    public abstract class BaseFileRepository : IFileRepository
    {
        public string DirectoryPath { get; }
        protected string[] FileExtensions { get; set; }
        
        protected BaseFileRepository(string directoryPath)
        {
            DirectoryPath = directoryPath;
            FileExtensions = new string[0];
        }

        public FileInfo[] GetFiles()
        {
            var objCurrentDirectory = new DirectoryInfo(DirectoryPath);
            if (!objCurrentDirectory.Exists)
                return null;

            var files =
                (from file in
                    FileExtensions.SelectMany(extension => objCurrentDirectory.GetFiles(extension)).ToList()
                    select file).ToArray();

            var forReturn = new FileInfo[files.Count()];
            for (var i = 0; i < files.Count(); i++)
            {
                var fileInfo = files[i];
                fileInfo.Refresh();
                forReturn[i] = fileInfo;
            }

            return forReturn;
        }
    }
}
