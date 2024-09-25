using EPiServer.Framework.DataAnnotations;

namespace firstlessen.Models
{
    [ContentType(GUID = "")]
    [MediaDescriptor(ExtensionString = "jpg,jepg,ico,gif,bmp,png,webp,pdf")]
    public class ImageFile : ImageData
    {
    }
}
