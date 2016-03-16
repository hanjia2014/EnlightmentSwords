using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.ComponentModel.DataAnnotations;

namespace EnlightmentSwords.FeaturedProduct.Models
{
    public class FeaturedProductPartRecord : ContentPartRecord
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Construction { get; set; }
        public virtual string HandGuard { get; set; }
        public virtual string Wood { get; set; }
        public virtual int BladeLength { get; set; }
        public virtual int TotalLength { get; set; }
        public virtual int Weight { get; set; }
        public virtual double Price { get; set; }
        public virtual string ImageUrl { get; set; }
    }

    public class FeaturedProductPart : ContentPart<FeaturedProductPartRecord>
    {
        [Required]
        public string Code { get { return Retrieve(r => r.Code); } set { Store(r => r.Code, value); } }
        [Required]
        public string Name { get { return Retrieve(r => r.Name); } set { Store(r => r.Name, value); } }
        public string Construction { get { return Retrieve(r => r.Construction); } set { Store(r => r.Construction, value); } }
        public string HandGuard { get { return Retrieve(r => r.HandGuard); } set { Store(r => r.HandGuard, value); } }
        public string Wood { get { return Retrieve(r => r.Wood); } set { Store(r => r.Wood, value); } }
        public int BladeLength { get { return Retrieve(r => r.BladeLength); } set { Store(r => r.BladeLength, value); } }
        public int TotalLength { get { return Retrieve(r => r.TotalLength); } set { Store(r => r.TotalLength, value); } }
        public int Weight { get { return Retrieve(r => r.Weight); } set { Store(r => r.Weight, value); } }
        [Required]
        public double Price { get { return Retrieve(r => r.Price); } set { Store(r => r.Price, value); } }
        public string ImageUrl { get { return Retrieve(r => r.ImageUrl); } set { Store(r => r.ImageUrl, value); } }
    }
}
