using PetBot.api.Dtos;
using PetBot.api.Entities;
using PetBot.api.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetBot.api.Service
{
    public class AgendamentoService : IAgendamentoService
    {

        public Task<Pet> NovoAgendamento(AgendamentoInputModel agendamentoIM)
        {
            var novoAgendamento = new Pet()
            {
                Id = Guid.NewGuid(),
                NomeDono = agendamentoIM.NomeDono,
                NomePet = agendamentoIM.NomePet,
                Servico = agendamentoIM.Servico,
                Porte = agendamentoIM.Porte,
                TellContato = agendamentoIM.TellContato,
            };

            return agendamentoIM;
        }
    }
}
