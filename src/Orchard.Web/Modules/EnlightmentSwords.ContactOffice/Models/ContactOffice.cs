using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.ComponentModel.DataAnnotations;

namespace EnlightmentSwords.ContactOffice.Models
{
    public class ContactOfficePartRecord : ContentPartRecord
    {
        public virtual string Name { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string FAX { get; set; }
        public virtual string Email { get; set; }
        public virtual string MSN { get; set; }
        public virtual string SkypeId { get; set; }
    }

    public class ContactOfficePart : ContentPart<ContactOfficePartRecord>
    {
        [Required]
        public string Name { get { return Retrieve(r => r.Name); } set { Store(r => r.Name, value); } }
        [Required]
        public string Telephone { get { return Retrieve(r => r.Telephone); } set { Store(r => r.Telephone, value); } }
        public string FAX { get { return Retrieve(r => r.FAX); } set { Store(r => r.FAX, value); } }
        [Required]
        public string Email { get { return Retrieve(r => r.Email); } set { Store(r => r.Email, value); } }
        public string MSN { get { return Retrieve(r => r.MSN); } set { Store(r => r.MSN, value); } }
        public string SkypeId { get { return Retrieve(r => r.SkypeId); } set { Store(r => r.SkypeId, value); } }
    }
}
