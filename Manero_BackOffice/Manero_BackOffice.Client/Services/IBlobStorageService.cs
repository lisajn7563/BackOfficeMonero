namespace Manero_BackOffice.Client.Services;

public interface IBlobStorageService
{
    Task<string> UploadFileToBlobAsync(string strFileName, string contecntType, Stream fileStream);
    Task<bool> DeleteFileToBlobAsync(string strFileName);
}
