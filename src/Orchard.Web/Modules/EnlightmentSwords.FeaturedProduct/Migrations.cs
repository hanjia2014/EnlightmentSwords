using System.Data;
using Orchard.Data.Migration;
using EnlightmentSwords.FeaturedProduct.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;

namespace EnlightmentSwords.FeaturedProduct
{
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table FeaturedProductPartRecord
			SchemaBuilder.CreateTable("FeaturedProductPartRecord", table => table
				.ContentPartRecord()
				.Column("Code", DbType.String)
				.Column("Name", DbType.String)
				.Column("Construction", DbType.String)
				.Column("HandGuard", DbType.String)
				.Column("Wood", DbType.String)
				.Column("BladeLength", DbType.Int32)
				.Column("TotalLength", DbType.Int32)
				.Column("Weight", DbType.Int32)
				.Column("Price", DbType.Double)
				.Column("ImageUrl", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(FeaturedProductPart).Name, cfg => cfg.Attachable());

            return 1;
        }
    }
}