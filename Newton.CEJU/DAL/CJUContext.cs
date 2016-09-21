﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using Newton.CJU.Models;

namespace Newton.CJU.DAL
{
    public class CJUContext : DbContext
    {
        public CJUContext() : base("CJUContext") 
        { 
        }

        public DbSet<AreaJuridica> AreasJuridicas { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}