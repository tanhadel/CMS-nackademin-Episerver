using System.ComponentModel.DataAnnotations;

namespace firstlessen
{
    public class Globals
    {
        [GroupDefinitions]
        public static class GroupNames
        {
            [Display(
                Name = "Metadaa",
                Order =40
                )]
            public const string Metadata = "Metadata";
            [Display(
                Name = "Specialized",
                Order = 90
                )]
            public const string Specialized = "Specialized";
        }
    }
}
