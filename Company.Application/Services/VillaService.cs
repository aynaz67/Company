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

        public async Task<Villa> GetVillasByIdAsync(int id)
        {
            return await _villaRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Villa>> GetVillasAsync()
        {
            return await _villaRepository.GetAllAsync();
        }

        public async Task AddVillasAsync(Villa entity)
        {
            _villaRepository.AddAsync(entity);


        }
        public async Task UpdateVillasAsync(Villa entity)
        {
            _villaRepository.UpdateAsync(entity);
        }

        public async Task DeleteVillasAsync(int id)
        {
            _villaRepository.DeleteAsync(id);
        }

    }
}
