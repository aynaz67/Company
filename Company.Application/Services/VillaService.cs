using Company.Domain.Entity;
using Company.Application.DTOs;
using AutoMapper;
using Company.Application.Interface;

namespace Company.Application.Services
{
    public class VillaService : IVillaService
    {
        private readonly IRepository<Villa> _villaRepository;
        private readonly IMapper _mapper;

        public VillaService(IRepository<Villa> villaRepository, IMapper mapper)
        {
            _villaRepository = villaRepository;
            _mapper = mapper;
        }

        public async Task<VillaDto?> GetVillasByIdAsync(int id)
        {
            var villa = await _villaRepository.GetByIdAsync(id);
            return _mapper.Map<VillaDto>(villa);

            //return new VillaDto
            //{
            //    Id = villa.Id,
            //    Name = villa.Name,
            //    Description = villa.Description
            //};
        }

        public async Task<IEnumerable<VillaDto>> GetVillasAsync()
        {
            var villas = await _villaRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<VillaDto>>(villas);

            //return villas.Select(v => new VillaDto
            //{
            //    Id = v.Id,
            //    Name = v.Name,
            //    Description = v.Description
            //});
        }

        public async Task AddVillasAsync(CreateUpdateVillaDto dto)
        {
            var villa = _mapper.Map<Villa>(dto);

            //var entity = new Villa
            //{
            //    Name = dto.Name,
            //    Description = dto.Description
            //};

            await _villaRepository.AddAsync(villa);
            await _villaRepository.SaveChangesAsync();
        }

        public async Task<bool> UpdateVillasAsync(VillaDto dto)
        {
            var existingVilla = await _villaRepository.GetByIdAsync(dto.Id);
            if (existingVilla == null)
                return false;

            //existingVilla.Name = dto.Name;
            //existingVilla.Description = dto.Description;
            //existingVilla.UpdateDate = dto.UpdateDate;

            //await _villaRepository.SaveChangesAsync();
            //return true;

            _mapper.Map(dto, existingVilla); // Map updated fields into existing entity
            existingVilla.UpdateDate = DateTime.UtcNow;

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