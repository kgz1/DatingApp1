using CloudinaryDotNet.Actions;

namespace APII.Interfaces

{
public interface IPhotoService
{
Task<ImageUploadResult> AddPhotoAsync(IFormFile file);

Task<DeletionResult> DeletePhotoAsync(string publicId);
}


}