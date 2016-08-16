namespace ImportExcel.Business.FileSearcher
{
    public class ExcelFileSearcher : BaseFileRepository
    {
        public ExcelFileSearcher(string directoryPath)
            : base(directoryPath)
        {
            base.FileExtensions = new string[2];
            base.FileExtensions[0] = "*.xlsx";
            base.FileExtensions[1] = "*.xls";
        }
    }
}
