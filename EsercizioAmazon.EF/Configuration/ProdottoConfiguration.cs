using EsercizioAmazon.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAmazon.EF.Configuration
{
    public class ProdottoConfiguration : IEntityTypeConfiguration<Prodotto>
    {
        public void Configure(EntityTypeBuilder<Prodotto> modelBuilder)
        {
            modelBuilder.ToTable("Prodotto");
            modelBuilder.HasKey(p => p.Codice);
            modelBuilder.Property(p => p.Descrizione).IsRequired();
            modelBuilder.Property(p => p._Tipologia).IsRequired();
            modelBuilder.Property(p => p.PrezzoPubblico).IsRequired();
            modelBuilder.Property(p => p.PrezzoFornitore).IsRequired();
        }
    }
}
