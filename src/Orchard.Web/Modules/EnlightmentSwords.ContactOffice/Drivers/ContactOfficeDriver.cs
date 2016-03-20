using EnlightmentSwords.ContactOffice.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace EnlightmentSwords.ContactOffice.Drivers
{
    public class ContactOfficeDriver : ContentPartDriver<ContactOfficePart>
    {
        protected override DriverResult Display(ContactOfficePart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_ContactOffice", () => shapeHelper.Parts_ContactOffice(
                Name: part.Name,
                Telephone: part.Telephone,
                FAX: part.FAX,
                Email: part.Email,
                MSN: part.MSN,
                SkypeId: part.SkypeId
                ));
        }

        //GET
        protected override DriverResult Editor(ContactOfficePart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_ContactOffice_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/ContactOffice",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(ContactOfficePart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

    }
}
