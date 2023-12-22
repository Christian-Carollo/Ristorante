using Ristorante.Entity;
using Ristorante.Repository;

namespace Ristorante.Service
{
    public class PlateService : IPlateService
    {
        private readonly IDb db;

        public PlateService(IDb db)
        {
            this.db = db;
        }

        public async Task CreatePlateAsync(Plate plate)
        {
           if(plate == null) { throw new ArgumentNullException(nameof(plate)); }
            db.plates.Add(plate);
            await Task.CompletedTask;

        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Plate>> GetAllPlate()
        {
            var plates = await Task.Run(() => db.plates);
            return plates;
        }

        public async Task<IEnumerable<Plate>> GetAllPlateType(string type)
        {
            var plates = await Task.Run(() => db.plates.Where(p => p.Type == type).ToList());
            return plates;
        }

        public async Task<IEnumerable<Plate>> GetAllPlateUnder10()
        {
            var plates = await Task.Run(() => db.plates.Where(p => p.Price < 10).ToList());
            return plates;
        }

        public async Task<Plate> GetById(Guid id)
        {
            var plates =  db.plates.FirstOrDefault(p => p.Id == id);
            if (plates == null) { throw new ArgumentNullException(nameof(plates)); }
            await Task.CompletedTask;
            return plates;
        }

        public async Task Update(Plate plate)
        {

            var plateUpdate = db.plates.FirstOrDefault(p => p.Id == plate.Id);
            if (plateUpdate == null) { throw new ArgumentNullException(nameof(plateUpdate)); }

            plateUpdate.Name = plate.Name;
            plateUpdate.Price = plate.Price;
            plateUpdate.Type = plate.Type;

            await Task.CompletedTask;
        }

        /*async async Task IPlateService.GetById(Guid id)
        {
            var delete = await Task.Run(() => db.plates.FirstOrDefault(e => e.Id == id));
            if (delete == null) { throw new ArgumentNullException(nameof(delete)); }
            return delete;
        }*/
    }
}
