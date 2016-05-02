using System.Runtime.CompilerServices;
using EnlightenmentSwords.FacebookPlugin.Models;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement;

namespace EnlightenmentSwords.FacebookPlugin.Drivers
{
    public class FacebookPluginDriver : ContentPartDriver<FacebookPluginPart>
    {
        protected override DriverResult Display(FacebookPluginPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_FacebookPlugin", () => shapeHelper.Parts_FacebookPlugin(
                FacebookPage: part.FacebookPage,
                AdaptContainerWidth: part.AdaptContainerWidth,
                Height: part.Height,
                Width: part.Width,
                Tabs: part.Tabs,
                ShowFacepile: part.ShowFacepile,
                ShowPosts: part.ShowPosts,
                SmallHeader: part.SmallHeader,
                HideCover: part.HideCover,
                HideCta: part.HideCta
                ));
        }

        //GET
        protected override DriverResult Editor(FacebookPluginPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_FacebookPlugin_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/FacebookPlugin",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(FacebookPluginPart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
