using EnlightmentSwords.FeaturedProduct.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace EnlightmentSwords.FeaturedProduct.Drivers
{
    public class FeaturedProductDriver : ContentPartDriver<FeaturedProductPart>
    {
        protected override DriverResult Display(FeaturedProductPart part, string displayType, dynamic shapeHelper)
        {
            //get the value from field, pass it to the contentshape below (same as other properties such as "Weight", "Wood" etc..., 
            //then it can be used in View, also need to comment in the display from Orchard.MediaLibrary/Views/Fields/MediaLibraryPicker.cshtml

            //var img = (MediaLibraryPickerField)part.Fields.FirstOrDefault(p => p.Name == "Picture");

            return ContentShape("Parts_FeaturedProduct", () => shapeHelper.Parts_FeaturedProduct(
                Name: part.Name,
                Code: part.Code,
                BladeLength: part.BladeLength,
                Construction: part.Construction,
                HandGuard: part.HandGuard,
                ImageUrl: part.ImageUrl,
                Price: part.Price,
                TotalLength: part.TotalLength,
                Weight: part.Weight,
                Wood: part.Wood
                ));
        }

        //GET
        protected override DriverResult Editor(FeaturedProductPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_FeaturedProduct_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/FeaturedProduct",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(FeaturedProductPart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

    }
}
