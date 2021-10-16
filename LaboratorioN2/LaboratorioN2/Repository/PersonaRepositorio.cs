using LaboratorioN2.Data;
using LaboratorioN2.Dominio;
using LaboratorioN2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioN2.Repository
{
    public class PersonaRepositorio : Ipersona
    {
        private ApplicationDbContext app;

        public PersonaRepositorio(ApplicationDbContext app)
        {
            this.app = app;
        }

        public void Save(persona E)
        {
            app.Add(E);
            app.SaveChanges();
        }

        public ICollection<persona> listardatos()
        {
            throw new NotImplementedException();
        }

    }
}
