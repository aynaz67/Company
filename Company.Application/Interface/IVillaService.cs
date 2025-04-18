using Company.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Interface
{
    public interface IVillaService
    {
        Task<VillaDto?> GetVillasByIdAsync(int id);
        Task<IEnumerable<VillaDto>> GetVillasAsync();
        Task AddVillasAsync(CreateUpdateVillaDto dto);
        Task<bool> UpdateVillasAsync(VillaDto dto);
        Task<bool> DeleteVillasAsync(int id);
    }
}
