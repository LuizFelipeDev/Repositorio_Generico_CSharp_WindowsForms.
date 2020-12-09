using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model.Interfaces;

namespace TrabBimestral.Model.Repositories
{
    public class RepositoryBAIRRO : RepositoryBase<Bairro> , IRepositoryBAIRRO
    {
        public RepositoryBAIRRO(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
