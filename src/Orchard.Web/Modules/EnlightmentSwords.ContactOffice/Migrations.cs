using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using EnlightmentSwords.ContactOffice.Models;

namespace EnlightmentSwords.ContactOffice
{
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table ContactOfficePartRecord
			SchemaBuilder.CreateTable("ContactOfficePartRecord", table => table
				.ContentPartRecord()
				.Column("Name", DbType.String)
				.Column("Telephone", DbType.String)
				.Column("FAX", DbType.String)
				.Column("Email", DbType.String)
				.Column("MSN", DbType.String)
				.Column("SkypeId", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(ContactOfficePart).Name, cfg => cfg.Attachable());

            return 1;
        }
    }
}