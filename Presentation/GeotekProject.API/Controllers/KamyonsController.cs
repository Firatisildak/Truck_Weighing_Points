using GeotekProject.Application.Interfaces;
using GeotekProject.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeotekProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KamyonsController(IKamyonRepository kamyonRepository) : ControllerBase
    {
        private readonly IKamyonRepository _kamyonRepository = kamyonRepository;

        [HttpGet("[action]")]
        public Task<IActionResult> GetAllKamyon() => Task.FromResult<IActionResult>(Ok(_kamyonRepository.GetAll()));

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdKamyon(string id) => Ok(await _kamyonRepository.GetById(id));

        [HttpPost("[action]")]
        public async Task<bool> CreateKamyon(Kamyon kamyon) => await _kamyonRepository.AddAsync(kamyon);

        [HttpPut("[action]")]
        public async Task<bool> UpdateKamyon(Kamyon kamyon) => await _kamyonRepository.Update(kamyon);

        [HttpDelete("[action]")]
        public async Task<bool> RemoveKamyon(string id) => await _kamyonRepository.RemoveAsync(id);

        [HttpGet("[action]")]
        public async Task<IActionResult> GetKamyonById(string Plaka) => Ok(await _kamyonRepository.GetById(Plaka));


    }
}
