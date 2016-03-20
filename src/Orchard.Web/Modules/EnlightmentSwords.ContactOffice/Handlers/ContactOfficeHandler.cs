using EnlightmentSwords.ContactOffice.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace EnlightmentSwords.ContactOffice.Handlers
{
    public class ContactOfficeHandler : ContentHandler
    {
        public ContactOfficeHandler(IRepository<ContactOfficePartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
