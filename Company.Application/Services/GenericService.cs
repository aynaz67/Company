using AutoMapper;
using Company.Application.DTOs;
using Company.Application.Interface;
using Company.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Company.Application.Services
{
    public class GenericService<T, TDto, TCreateUpdateDto> 
        
        : IGenericService<T,TDto, TCreateUpdateDto>
           where T : class
    where TDto : class
    where TCreateUpdateDto : class
    {
        private readonly IRepository<T> _villaRepository;
        private readonly IMapper _mapper;

        public GenericService(IRepository<T> villaRepository, IMapper mapper)
        {
            _villaRepository = villaRepository;
            _mapper = mapper;
        }

        public async Task<TDto?> GetVillasByIdAsync(int id)
        {
            var villa = await _villaRepository.GetByIdAsync(id);
            return _mapper.Map<TDto>(villa);

            //return new VillaDto
            //{
            //    Id = villa.Id,
            //    Name = villa.Name,
            //    Description = villa.Description
            //};
        }

        public async Task<IEnumerable<TDto>> GetVillasAsync()
        {
            var villas = await _villaRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(villas);

            //return villas.Select(v => new VillaDto
            //{
            //    Id = v.Id,
            //    Name = v.Name,
            //    Description = v.Description
            //});
        }

        public async Task AddVillasAsync(TCreateUpdateDto dto)
        {
            var villa = _mapper.Map<T>(dto);
            //var entity = new Villa
            //{
            //    Name = dto.Name,
            //    Description = dto.Description
            //};
            await _villaRepository.AddAsync(villa);
            await _villaRepository.SaveChangesAsync();
        }

        public async Task<bool> UpdateVillasAsync(int id, TDto dto)
        {
            var existingVilla = await _villaRepository.GetByIdAsync(id);
            if (existingVilla == null)
                return false;

            //existingVilla.Name = dto.Name;
            //existingVilla.Description = dto.Description;
            //existingVilla.UpdateDate = dto.UpdateDate;

            //await _villaRepository.SaveChangesAsync();
            //return true;

            _mapper.Map(dto, existingVilla); // Map updated fields into existing entity
                                             //  existingVilla.UpdateDate = DateTime.UtcNow;
                                             //reflection
            var property = existingVilla.GetType().GetProperty("UpdateDate");
            if (property != null)
            {
                property.SetValue(existingVilla, DateTime.UtcNow);
            }
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
