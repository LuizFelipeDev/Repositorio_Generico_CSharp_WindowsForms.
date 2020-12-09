using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model;
using TrabBimestral.Model.Repositories;

namespace TrabBimestral.View.Controller
{
    public class CCadTipoLogradouro : IDisposable
    {
        RepositoryTIPOLOGRADOURO _Repository = new RepositoryTIPOLOGRADOURO();
        public void CadastrarTipoLogradouro(Tipo_Logradouro oTIPOLOGRADOURO)
        {
            _Repository.Incluir(oTIPOLOGRADOURO);
        }

        public List<Tipo_Logradouro> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }

        public Tipo_Logradouro Selecionar(int ID)
        {
            return _Repository.SelecionarPK(ID);
        }

        public void Alterar(Tipo_Logradouro otipo_Logradouro)
        {
            _Repository.Alterar(otipo_Logradouro);
        }

        public void Excluir(Tipo_Logradouro oTIPOLOGRADOURO)
        {
            _Repository.Excluir(oTIPOLOGRADOURO);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
