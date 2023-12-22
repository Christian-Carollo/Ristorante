namespace Ristorante.Entity
{
    public class Plate
    {

        public Guid Id {  get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int Price { get; set; }
    }
}
