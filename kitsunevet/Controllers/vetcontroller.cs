using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kitsunevet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class vetController : ControllerBase
    {
        
        [HttpPost]

        public Models.TbCliente Salvar(Models.TbCliente cliente)
        {

            Models.veterinarioContext ctx = new Models.veterinarioContext();

            ctx.TbCliente.Add(cliente);
            ctx.SaveChanges();

            return cliente;

        }

    }
}