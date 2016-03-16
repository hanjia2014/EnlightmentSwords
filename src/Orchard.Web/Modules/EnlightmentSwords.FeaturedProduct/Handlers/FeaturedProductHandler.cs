using EnlightmentSwords.FeaturedProduct.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace EnlightmentSwords.FeaturedProduct.Handlers
{
    public class FeaturedProductHandler : ContentHandler
    {
        public FeaturedProductHandler(IRepository<FeaturedProductPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
