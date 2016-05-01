using EnlightenmentSwords.FacebookPlugin.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace EnlightenmentSwords.FacebookPlugin.Handlers
{
    public class FacebookPluginHandler : ContentHandler
    {
        public FacebookPluginHandler(IRepository<FacebookPluginPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
