using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model;
using TrabBimestral.Model.Repositories;

namespace TrabBimestral.View.Controller
{
    public class CCadDependente : IDisposable
    {
        RepositoryDEPENDENTE _Repository = new RepositoryDEPENDENTE();
        public void CadastrarDependente(Dependente oDependente)
        {
            _Repository.Incluir(oDependente);
        }

        public List<Dependente> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public Dependente Selecionar(int ID)
        {
            return _Repository.SelecionarPK(ID);
        }

        public void Excluir(Dependente oDependente)
        {
            _Repository.Excluir(oDependente);
        }

        public void Alterar(Dependente oDependente)
        {
            _Repository.Alterar(oDependente);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
