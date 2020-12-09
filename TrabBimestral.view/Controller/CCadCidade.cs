using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model;
using TrabBimestral.Model.Repositories;

namespace TrabBimestral.View.Controller
{
    public class CCadCidade : IDisposable
    {
        RepositoryCIDADE _Repository = new RepositoryCIDADE();
        public void CadastrarCidade(Cidade oCidade)
        {
            _Repository.Incluir(oCidade);
        }

        public List<Cidade> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public Cidade Selecionar(int ID)
        {
            return _Repository.SelecionarPK(ID);
        }

        public void Alterar(Cidade oCidade)
        {
            _Repository.Alterar(oCidade);
        }

        public void Excluir(Cidade oCidade)
        {
            _Repository.Excluir(oCidade);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
