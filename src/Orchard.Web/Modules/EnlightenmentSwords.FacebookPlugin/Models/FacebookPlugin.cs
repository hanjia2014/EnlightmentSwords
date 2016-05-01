using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.ComponentModel.DataAnnotations;

namespace EnlightenmentSwords.FacebookPlugin.Models
{
    public class FacebookPluginPartRecord : ContentPartRecord
    {
        public virtual string FacebookPage { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual string Tabs { get; set; }
        public virtual bool HideCover { get; set; }
        public virtual bool ShowFacepile { get; set; }
        public virtual bool HideCta { get; set; }
        public virtual bool SmallHeader { get; set; }
        public virtual bool AdaptContainerWidth { get; set; }
        public virtual bool ShowPosts { get; set; }
    }

    public class FacebookPluginPart : ContentPart<FacebookPluginPartRecord>
    {
        [Required]
        public string FacebookPage { get { return Retrieve(r => r.FacebookPage); } set { Store(r => r.FacebookPage, value); } }
        public int Width { get { return Retrieve(r => r.Width); } set { Store(r => r.Width, value); } }
        public int Height { get { return Retrieve(r => r.Height); } set { Store(r => r.Height, value); } }
        public string Tabs { get { return Retrieve(r => r.Tabs); } set { Store(r => r.Tabs, value); } }
        public bool HideCover { get { return Retrieve(r => r.HideCover); } set { Store(r => r.HideCover, value); } }
        public bool ShowFacepile { get { return Retrieve(r => r.ShowFacepile); } set { Store(r => r.ShowFacepile, value); } }
        public bool HideCta { get { return Retrieve(r => r.HideCta); } set { Store(r => r.HideCta, value); } }
        public bool SmallHeader { get { return Retrieve(r => r.SmallHeader); } set { Store(r => r.SmallHeader, value); } }
        public bool AdaptContainerWidth { get { return Retrieve(r => r.AdaptContainerWidth); } set { Store(r => r.AdaptContainerWidth, value); } }
        public bool ShowPosts { get { return Retrieve(r => r.ShowPosts); } set { Store(r => r.ShowPosts, value); } }
    }
}
