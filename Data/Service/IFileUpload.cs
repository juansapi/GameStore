using BlazorInputFile;
using System.Threading.Tasks;

namespace WebApplication1.Data.Service
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry fileEntry);
    }
}