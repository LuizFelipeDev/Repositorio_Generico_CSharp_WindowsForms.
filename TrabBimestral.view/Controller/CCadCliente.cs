using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model;
using TrabBimestral.Model.Repositories;

namespace TrabBimestral.View.Controller
{
    public class CCadCliente :IDisposable
    {
        RepositoryCLIENTE _Repository = new RepositoryCLIENTE();
        public void CadastrarCliente(Cliente oCliente)
        {
            _Repository.Incluir(oCliente);
        }

        public List<Cliente> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public Cliente Selecionar(int ID)
        {
            return _Repository.SelecionarPK(ID);
        }

        public void Excluir(Cliente oCliente)
        {
           _Repository.Excluir(oCliente);
        }

        public void Alterar(Cliente oCliente)
        {
            _Repository.Alterar(oCliente);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
