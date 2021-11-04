using PetBot.api.Dtos;
using PetBot.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetBot.api.Service
{
    public interface IAgendamentoService
    {
        public Task<Pet> NovoAgendamento(AgendamentoInputModel novoAgendamento);
    }
}
