namespace RailwayWeb.Data
{
    public class WagonType
    {
        public int WagonTypeID { get; set; }
       
        public string Name { get; set; } = string.Empty;
        public int Electrified { get; set; }
    }
}