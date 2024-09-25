using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Initialization;
using EPiServer.ServiceLocation;

namespace firstlessen.Business.Initilazaion
{
    [InitializableModule]
    [ModuleDependency(typeof(CmsCoreInitialization))]
    public class CategoryInitalization: IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            CreatCategory();
        }

        private void CreatCategory()
        {
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            var root = categoryRepository.GetRoot();
            if(categoryRepository.Get("Film genres") == null)

            {
                var systemCategory = new Category(root, "Film genres")
                {
                    Available = true,
                    Description = "Film genres",
                    Selectable = false
                };

                categoryRepository.Save(systemCategory);
 
            }

            var heading = categoryRepository.Get("Film genres");

            var genres = new List<string>
                {
                    "Horror","Action","Comedy","Drama","Fantasy","Science fiction",
                    "Romance","Thriller","Mystery","Crime","Adventure","Animation","Family",
                    "War","History","Documentary","Music","Western","TV movie","Foreign"
                };

            foreach (var genre in genres)
            {
                if (categoryRepository.Get(genre) == null)
                {
                    var category = new Category(heading, genre)
                    {
                        Available = true,
                        Description = genre,
                        Selectable = true
                    };

                    categoryRepository.Save(category);
                }

            }

        }

        public void Uninitialize(InitializationEngine context)
        {
            //throw new System.NotImplementedException();
        }

    }

}
