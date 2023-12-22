using Ristorante.Entity;

namespace Ristorante.Repository
{
    public interface IDb
    {
        public List<Plate> plates { get; set; }
    }
}
