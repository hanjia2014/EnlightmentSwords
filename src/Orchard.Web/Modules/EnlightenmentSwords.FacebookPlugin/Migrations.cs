using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using EnlightenmentSwords.FacebookPlugin.Models;

namespace EnlightenmentSwords.FacebookPlugin
{
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table FacebookPluginPartRecord
			SchemaBuilder.CreateTable("FacebookPluginPartRecord", table => table
				.ContentPartRecord()
				.Column("FacebookPage", DbType.String)
				.Column("Width", DbType.Int32)
				.Column("Height", DbType.Int32)
				.Column("Tabs", DbType.String)
				.Column("HideCover", DbType.Boolean)
				.Column("ShowFacepile", DbType.Boolean)
				.Column("HideCta", DbType.Boolean)
				.Column("SmallHeader", DbType.Boolean)
				.Column("AdaptContainerWidth", DbType.Boolean)
				.Column("ShowPosts", DbType.Boolean)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(FacebookPluginPart).Name, cfg => cfg.Attachable());

            return 1;
        }
    }
}