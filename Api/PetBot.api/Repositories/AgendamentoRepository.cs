using Microsoft.EntityFrameworkCore;
using PetBot.api.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetBot.api.Repositories
{
    public class AgendamentoRepository
    {
        private AppDbContext _context;

        public AgendamentoRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
