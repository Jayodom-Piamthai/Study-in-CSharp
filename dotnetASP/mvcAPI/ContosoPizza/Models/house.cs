namespace ContosoPizza.Models
{
    public class house
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsGlutenFree { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public int NumberOfRooms { get; set; }
        public decimal Price { get; set; }
    }
}
