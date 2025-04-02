using Company.Application.Services.Interfaces;
using Company.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<Villa>> GetProductsAsync()
        {
            return await _villaRepository.GetAllAsync();
        }
    }
}
