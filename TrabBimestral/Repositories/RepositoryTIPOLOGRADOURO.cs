using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model.Interfaces;

namespace TrabBimestral.Model.Repositories
{
    public class RepositoryTIPOLOGRADOURO : RepositoryBase<Tipo_Logradouro> , IRepositoryTIPOLOGRADOURO
    {
        public RepositoryTIPOLOGRADOURO(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
