namespace rimrock_api.Models
{
    // https://github.com/house-rimrock/rimrock/blob/master/assets/db-schema-rimrock.png
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public int RegionID { get; set; }
    }
}
