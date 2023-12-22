using Ristorante.Entity;

namespace Ristorante.Service
{
    public interface IPlateService
    {
        Task CreatePlateAsync(Plate plate);

        Task<IEnumerable<Plate>> GetAllPlate ();

        Task<IEnumerable<Plate>> GetAllPlateUnder10();

        Task<IEnumerable<Plate>> GetAllPlateType(string type );

        Task Update(Plate plate);

        Task GetById(Guid id);

        Task Delete(Guid id);
    }
}
