using Orchard.Data.Migration;

namespace My.Spatial
{
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("TestRecord", table => table
                .Column<int>("Id", column => column.PrimaryKey().Identity())

                );
            return 1;
        }

        public int UpdateFrom1() {
            SchemaBuilder.AlterTable("TestRecord", table => table
                .AddColumn<GeoAPI.Geometries.IGeometry>("Geometry"));
            return 2;
        }
//
//        public int UpdateFrom2() {
//            SchemaBuilder.AlterTable("TestRecordddd", table => table
//                .AddColumn<string>("Code"));
//            SchemaBuilder.AlterTable("TestRecordddd", table => table
//                .AddColumn<GeoAPI.Geometries.IGeometry>("Geometry"));
//            return 3;
//        }
    }
}
