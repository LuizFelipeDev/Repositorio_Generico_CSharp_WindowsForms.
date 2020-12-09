using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model;
using TrabBimestral.Model.Repositories;

namespace TrabBimestral.View.Controller
{
    public class CCadTipoDependente : IDisposable
    {
        RepositoryTIPODEPENDENTE _Repository = new RepositoryTIPODEPENDENTE();
        public void CadastrarTipoDependente(TipoDependente oTipoDependente)
        {
            _Repository.Incluir(oTipoDependente);
        }

        public List<TipoDependente> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public TipoDependente Selecionar(int ID)
        {
            return _Repository.SelecionarPK(ID);
        }

        public void Alterar(TipoDependente oTipoDependente)
        {
            _Repository.Alterar(oTipoDependente);
        }

        public void Excluir(TipoDependente oTipoDependente)
        {
            _Repository.Excluir(oTipoDependente);
        }
        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
