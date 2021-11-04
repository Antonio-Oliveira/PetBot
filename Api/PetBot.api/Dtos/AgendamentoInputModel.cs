using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetBot.api.Dtos
{
    public class AgendamentoInputModel
    {
        public string NomePet { get; set; }

        public int Porte { get; set; }

        public int Servico { get; set; }

        public int TellContato { get; set; }

        public string NomeDono { get; set; }
    }
}
