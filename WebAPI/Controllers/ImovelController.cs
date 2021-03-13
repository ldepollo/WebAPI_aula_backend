using Imobiliaria.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImovelController
    {
        //localhost:1234/imovel
        [HttpGet]
        public async Task<ActionResult< List<Imovel> >> ListImoveis()
        {
            Imovel exemplo = new Imovel
            {
                Bairro = "Itaparica",
                Cep = "00000-00",
                Id = 1,
                Numero = 11,
                Preco = 300000,
                Premio = 15,
                Rua = "Rodosol",
                Tipo = 1
            };
            List<Imovel> listaDeImoveis = new List<Imovel> { exemplo };
            return new OkObjectResult(listaDeImoveis);
        }
        //localhost:1234/imovel/25
        [HttpGet("{id}")]
        public async Task<ActionResult<Imovel>> GetImovel(int id)
        {
            Imovel exemplo = new Imovel
            {
                Bairro = "Itaparica",
                Cep = "00000-00",
                Id = id,
                Numero = 11,
                Preco = 300000,
                Premio = 15,
                Rua = "Rodosol",
                Tipo = 1
            };
            return new OkObjectResult(exemplo);
        }


    }
}
