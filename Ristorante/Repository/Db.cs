using Ristorante.Entity;

namespace Ristorante.Repository
{
    public class Db : IDb
    {


        List<Plate> IDb.plates { get; set; } = new();
    }
}
