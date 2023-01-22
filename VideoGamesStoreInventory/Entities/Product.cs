namespace VideoGamesStoreInventory.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBought { get; set; } // add popup callendar in the future
        public DateTime? DateSold { get; set; }
        public int FacilityBoughtId { get; set; }
        public int FacilitySoldId { get; set; }
        public string Barcode { get; set; }
    }
}
