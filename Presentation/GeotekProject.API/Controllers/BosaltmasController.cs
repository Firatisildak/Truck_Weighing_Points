using GeotekProject.Application.DTOs.Bosaltma;
using GeotekProject.Application.Interfaces;
using GeotekProject.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeotekProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BosaltmasController(IBosaltmaRepository bosaltmaRepository) : ControllerBase
    {
        private readonly IBosaltmaRepository _bosaltmaRepository = bosaltmaRepository;

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllBosaltma() => Ok(_bosaltmaRepository.GetAll());

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdBosaltma(string id) => Ok(await _bosaltmaRepository.GetById(id));

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllBosaltmalarWithKamyon() => Ok(await _bosaltmaRepository.GetAllWithKamyonAsync());

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateBosaltma(CreateBosaltma createBosaltma)
        {
            Bosaltma bosaltma = new()
            {
                BosaltmaDurumu = createBosaltma.BosaltmaDurumu,
                Plaka = createBosaltma.Plaka,
                KamyonId = createBosaltma.KamyonId
            };
            await _bosaltmaRepository.AddAsync(bosaltma);
            return Ok();
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateBosaltma(UpdateBosaltma updateBosaltma)
        {
            Bosaltma bosaltma = new()
            {
                Id = updateBosaltma.Id,
                BosaltmaDurumu = updateBosaltma.BosaltmaDurumu,
                Plaka = updateBosaltma.Plaka,
                KamyonId = updateBosaltma.KamyonId,
            };
            await _bosaltmaRepository.Update(bosaltma);
            return Ok();
        }

        [HttpDelete("[action]")]
        public async Task<bool> RemoveBosaltma(string id) => await _bosaltmaRepository.RemoveAsync(id);

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBosaltmaById(string BosaltmaId) => Ok(await _bosaltmaRepository.GetById(BosaltmaId));
    }
}
