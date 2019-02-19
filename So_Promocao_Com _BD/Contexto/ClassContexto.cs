using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using So_Promocao_Com__BD.Models;

namespace So_Promocao_Com__BD.Contexto
{
    public class ClassContexto:DbContext
    {
        public ClassContexto() : base("ClassContexto")
        {
        }
        public DbSet<Usuario> ListaUsuarios { get; set; }
        public DbSet<Empresa> ListaEmpresas { get; set; }
    }
}