using System;
using Entitty.BOL.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Entity.DAL
{
    public class BDContext : DbContext
    {
        #region Tablas

        public DbSet<Usuario> Usuario { get; set; }

        #endregion

        #region Vistas

        

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigApp app = new ConfigApp();
            optionsBuilder.UseSqlServer(app.CadenaConexion);
        }
    }
}
