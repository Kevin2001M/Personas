using LaboratorioN2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioN2.Service
{
    public interface Ipersona
    {

        void Save(persona E);

        ICollection<persona> listardatos();

    }
}
