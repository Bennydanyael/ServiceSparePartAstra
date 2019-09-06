using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceSparePartAstra.Models
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> _option) : base(_option)
        {
        }

        public DbSet<Customers> Customers { get; set; }
        //public DbSet<TransaksiKasKecil> TransaksiKasKecil { get; set; }
        //public DbSet<TransaksiKasBesar> TransaksiKasBesar { get; set; }
        //public DbSet<PelunasanServiceKasKecil> PelunasanServiceKasKecil { get; set; }
        //public DbSet<PelunasanServiceKasBesar> PelunasanServiceKasBesar { get; set; }
        //public DbSet<PelunasanPartsKasKecil> PelunasanPartsKasKecils { get; set; }
        //public DbSet<PelunasanPartsKasBesar> PelunasanPartsKasBesar { get; set; }
    }
}
