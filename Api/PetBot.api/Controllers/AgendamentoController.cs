using Microsoft.AspNetCore.Mvc;
using PetBot.api.Dtos;
using PetBot.api.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetBot.api.Controllers
{
    public class AgendamentoController : Controller
    {
        private IAgendamentoService _agendamentoService;

        public AgendamentoController(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }


        [HttpGet]
        public IActionResult Index(AgendamentoInputModel petAgendamentoIM)
        {
            if (!ModelState.IsValid)
                return BadRequest("Erro ao cadastrar pet");

            var agendamento = _agendamentoService.NovoAgendamento(petAgendamentoIM);

            if (agendamento == null)
                return BadRequest("Erro ao cadastrar pet");

            return Ok(agendamento);
        }
    }
}
