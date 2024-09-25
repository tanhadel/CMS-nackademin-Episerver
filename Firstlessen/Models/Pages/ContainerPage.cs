namespace firstlessen.Models.Pages
{
    [ContentType(
    GUID = "04F3A5C0-9C56-45C2-AAC1-BC08E36D879E"
    )]
    [AvailableContentTypes(Availability.Specific,
        Include = [typeof(SlideshowPage)]
    )]
    public class ContainerPage: PageData,IContainerPage
    {

    }
}
