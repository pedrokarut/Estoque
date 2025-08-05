using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Classes;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Databse
{
    public class DbConnection : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=ep-flat-frog-ack9fft2-pooler.sa-east-1.aws.neon.tech; Database=neondb; Username=neondb_owner; Password=npg_Zokm0BVp2XAT; SSL Mode=VerifyFull; Channel Binding=Require;");

    }
}
