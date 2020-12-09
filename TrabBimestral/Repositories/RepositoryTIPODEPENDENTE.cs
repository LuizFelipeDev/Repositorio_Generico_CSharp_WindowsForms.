using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model.Interfaces;

namespace TrabBimestral.Model.Repositories
{
    public class RepositoryTIPODEPENDENTE : RepositoryBase<TipoDependente> , IRepositoryTIPODEPENDENTE
    {
        public RepositoryTIPODEPENDENTE(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
