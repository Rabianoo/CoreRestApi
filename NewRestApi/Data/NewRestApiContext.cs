using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewRestApi.Model;

namespace NewRestApi.Data
{
    public class NewRestApiContext : DbContext
    {
        public NewRestApiContext (DbContextOptions<NewRestApiContext> options)
            : base(options)
        {
        }

        public DbSet<NewRestApi.Model.Students> Students { get; set; } = default!;
    }
}
