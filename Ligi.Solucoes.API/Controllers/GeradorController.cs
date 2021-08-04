using Bogus;
using Bogus.Extensions.Brazil;
using Ligi.Solucoes.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Ligi.Solucoes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeradorController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(PessoaViewModel), 200)]
        public IActionResult Get()
        {
            var faker = new Faker("pt_BR");
            var pessoaFake = new PessoaViewModel()
            {
                Bairro = faker.Address.City(),
                Cep = faker.Address.ZipCode(),
                Cidade = faker.Address.City(),
                Estado = faker.Address.StateAbbr(),
                Logradouro = faker.Address.StreetName(),
                Cpf = faker.Person.Cpf(),
                Nome = faker.Person.FullName,
                Numero = faker.Address.BuildingNumber()
            };

            return Ok(pessoaFake);

        }
    }
}
