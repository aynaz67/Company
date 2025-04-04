using Company.Application.Services.Interfaces;
using Company.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Services
{
    public class VillaService
    {
        private readonly IRepository<Villa> _villaRepository;

        public VillaService(IRepository<Villa> productRepository)
        {
            _villaRepository = productRepository;
        }

        public async Task<Villa?> GetVillasByIdAsync(int id)
        {
            return await _villaRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Villa>> GetVillasAsync()
        {
            return await _villaRepository.GetAllAsync();
        }

        public async Task AddVillasAsync(Villa entity)
        {
            await _villaRepository.AddAsync(entity);
            await _villaRepository.SaveChangesAsync();
        }
        public async Task<bool> UpdateVillasAsync(Villa entity)
        {
            var existingVilla = await _villaRepository.GetByIdAsync(entity.Id);
            if (existingVilla == null)
                return false;
            existingVilla.Name = entity.Name;
            existingVilla.Description = entity.Description;
            existingVilla.CreateDate = entity.CreateDate;
            existingVilla.UpdateDate = entity.UpdateDate;
   
            await _villaRepository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteVillasAsync(int id)
        {
            var existingVilla = await _villaRepository.GetByIdAsync(id);
            if (existingVilla == null)
                return false;

            await _villaRepository.DeleteAsync(existingVilla);
            await _villaRepository.SaveChangesAsync();
            return true;
        }

    }
}
