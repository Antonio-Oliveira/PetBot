using PetBot.api.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetBot.api.Entities
{
    public class Pet
    {
        public Guid Id { get; set; }

        public string NomePet { get; set; }

        public int Porte { get; set; }

        public int Servico { get;set; }
        
        public int TellContato { get; set; }

        public string NomeDono { get; set; }

    }
}
