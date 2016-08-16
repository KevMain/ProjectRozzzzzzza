using System;
using System.IO;

namespace ImportExcel.Business.FileSearcher
{
    public interface IFileRepository
    {
        FileInfo[] GetFiles();
    }
}
