using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model;
using TrabBimestral.Model.Repositories;

namespace TrabBimestral.View.Controller
{
    public class CCadBairro : IDisposable
    {
        RepositoryBAIRRO _Repository = new RepositoryBAIRRO();
        public void CadastrarBairro(Bairro oBairro)
        {
            _Repository.Incluir(oBairro);
        }

        public List<Bairro> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public Bairro Selecionar(int ID)
        {
            return _Repository.SelecionarPK(ID);
        }

        public void Alterar(Bairro oBairro)
        {
            _Repository.Alterar(oBairro);
        }

        public void Excluir(Bairro oBairro)
        {
            _Repository.Excluir(oBairro);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}