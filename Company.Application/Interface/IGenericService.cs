using Company.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Interface
{
    public interface IGenericService<T,TDto, TCreateUpdateDto>
    where TDto : class
    where TCreateUpdateDto : class
    {
        Task<TDto?> GetVillasByIdAsync(int id);
        Task<IEnumerable<TDto>> GetVillasAsync();
        Task AddVillasAsync(TCreateUpdateDto dto);
        Task<bool> UpdateVillasAsync(int id, TDto dto);
        Task<bool> DeleteVillasAsync(int id);
    }
}
