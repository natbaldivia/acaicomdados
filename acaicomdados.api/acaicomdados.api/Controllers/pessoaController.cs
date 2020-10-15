using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acaicomdados.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pessoaController : ControllerBase
    {
        List<pessoa> tabelaFake;

        public pessoaController()
        {
            tabelaFake = new List<pessoa>();

            tabelaFake.Add(new pessoa() { DataNascimento = new DateTime(1991, 08, 09), estadocivil = estadocivil.Casado, Id = 1, Nome = "Natalia" });
            tabelaFake.Add(new pessoa() { DataNascimento = new DateTime(1992, 02, 05), estadocivil = estadocivil.Casado, Id = 2, Nome = "Everton"});
            tabelaFake.Add(new pessoa() { DataNascimento = new DateTime(1999, 01, 26), estadocivil = estadocivil.Solteiro, Id = 3, Nome = "Luana"});
        }

        // GET: api/pessoa
        [HttpGet]
        public IEnumerable<pessoa> Get()
        {
            return tabelaFake;
        }

        [HttpGet("{id}")]
        public pessoa Get(int id)
        {
            return tabelaFake.FirstOrDefault(x => x.Id == id);
        }

        // POST: api/pessoa
        [HttpPost]
        public IEnumerable<pessoa> Post([FromBody] string value)
        {
            tabelaFake.Add(new pessoa { DataNascimento = new DateTime(1986, 06, 30), Id = 4, estadocivil = estadocivil.Casado, Nome = "Bololo" });
            return tabelaFake;
        }

        // PUT: api/pessoa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           // tabelaFake.Remove()
        }
    }
}
