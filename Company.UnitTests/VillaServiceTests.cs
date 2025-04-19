using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Application.Interface;
using Moq;
using Company.Domain.Entity;
using AutoMapper;
using Company.Application.DTOs;
using Company.Application.Services;


namespace Company.UnitTests
{
    public class VillaServiceTests
    {
        private readonly Mock<IRepository<Villa>> _villaRepoMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly VillaService villaService;

        public VillaServiceTests()
        {
            _villaRepoMock = new Mock<IRepository<Villa>>();
            _mapperMock = new Mock<IMapper>();
            villaService = new VillaService(_villaRepoMock.Object, _mapperMock.Object);

        }

        [Fact]
        public async Task GetVillasByIdAsync_ReturnsDto_WhenVillaExists()
        {
            var villa = new Villa
            {
                Id = 1,
                Name = "Test Villa",
                Description = "Test Description"
            };
            var villaDto = new VillaDto
            {
                Id = 1,
                Name = "Test Villa",
                Description = "Test Description"
            };
            _villaRepoMock.Setup(x => x.GetByIdAsync(1)).ReturnsAsync(villa);
            _mapperMock.Setup(x => x.Map<VillaDto>(villa)).Returns(villaDto);
            var result = await villaService.GetVillasByIdAsync(1);
            Assert.NotNull(result);
            Assert.Equal(villaDto.Id, result.Id);
            Assert.Equal(villaDto.Name, result.Name);
        }

        [Fact]
        public async Task GetVillasByIdAsync_ReturnsNull_WhenVillaNotFound()
        {
            _villaRepoMock.Setup(x => x.GetByIdAsync(1)).ReturnsAsync((Villa)null);
            var result = await villaService.GetVillasByIdAsync(1);
            Assert.Null(result);
        }

        [Fact]
        public async Task AddVillasAsync_CallsAddAndSaveChanges()
        {
            var dto = new CreateUpdateVillaDto
            {
                Name = "Test Villa",
                Description = "Test Description"
            };
            var villa = new Villa
            {
                Id = 1,
                Name = "Test Villa",
                Description = "Test Description"
            };
            _mapperMock.Setup(x => x.Map<Villa>(dto)).Returns(villa);

            _villaRepoMock.Setup(x => x.AddAsync(villa)).Returns(Task.CompletedTask);
            _villaRepoMock.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

            await villaService.AddVillasAsync(dto);

            _villaRepoMock.Verify(r => r.AddAsync(It.Is<Villa>(v => v.Name == "Test Villa")), Times.Once);
            _villaRepoMock.Verify(x => x.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task UpdateVillasAsync_ReturnsFalse_WhenVillaNotFound()
        {
            var dto = new VillaDto
            {
                Id = 1,
                Name = "Test Villa",
                Description = "Test Description"
            };

            _villaRepoMock.Setup(x => x.GetByIdAsync(1)).ReturnsAsync((Villa)null);

            var result = await villaService.UpdateVillasAsync(dto);

            Assert.False(result);
        }

        [Fact]
        public async Task UpdateVillasAsync_ReturnsTrue_WhenVillaExists()
        {
            var dto = new VillaDto
            {
                Id = 1,
                Name = "Test Villa",
                Description = "Test Description"
            };
            var villa = new Villa
            {
                Id = 1,
                Name = "Test Villa",
                Description = "Test Description"
            };
            _villaRepoMock.Setup(x => x.GetByIdAsync(1)).ReturnsAsync(villa);
            _mapperMock.Setup(x => x.Map<Villa>(dto)).Returns(villa);
            _villaRepoMock.Setup(x => x.UpdateAsync(villa)).Returns(Task.CompletedTask);
            _villaRepoMock.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);
            var result = await villaService.UpdateVillasAsync(dto);
            Assert.True(result);
        }

        [Fact]
        public async Task DeleteVillasAsync_ReturnsFalse_WhenVillaNotFound()
        {
            _villaRepoMock.Setup(x => x.GetByIdAsync(1)).ReturnsAsync((Villa)null);
            var result = await villaService.DeleteVillasAsync(1);
            Assert.False(result);
        }

        [Fact]
        public async Task DeleteVillasAsync_ReturnsTrue_WhenVillaExists()
        {
            var villa = new Villa
            {
                Id = 1,
                Name = "Test Villa",
                Description = "Test Description"
            };
            _villaRepoMock.Setup(x => x.GetByIdAsync(1)).ReturnsAsync(villa);
            _villaRepoMock.Setup(x => x.DeleteAsync(villa)).Returns(Task.CompletedTask);
            _villaRepoMock.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);
            var result = await villaService.DeleteVillasAsync(1);
            Assert.True(result);
        }
    }
}