using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabBimestral.Model.Interfaces;
using TrabBimestral.Model;
using System.Data.Entity;
using System.Data.Odbc;
using System.Data.Entity.Migrations;

namespace TrabBimestral.Model.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryModel<T> , IDisposable where T : class 
    {
        private bool _SaveChanges = true;
        protected DbContext _Contexto;

        public RepositoryBase(bool SaveChanges = true)
        {
            _SaveChanges = SaveChanges;
            _Contexto = new BimestralTrabEntities();
            _Contexto.Configuration.ProxyCreationEnabled = false;
        }
        public T Alterar(T objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;           
            if (_SaveChanges)
            {
                _Contexto.SaveChanges();              
            }
            return objeto;
        }

        public void Excluir(T objeto)
        {
            _Contexto.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                try
                {
                    _Contexto.SaveChanges();
                }
                catch(Exception ex)
                {                  
                    _Contexto.Entry(objeto).State = EntityState.Unchanged;
                    _Contexto.SaveChanges();                   
                    throw ex;
                }
            }
        }

        public void Excluir(params object[] variavel)
        {
            var objeto = SelecionarPK(variavel);
            Excluir(objeto);           
        }

        public T Incluir(T objeto)
        {            
            _Contexto.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
               _Contexto.SaveChanges();
               _Contexto.Entry(objeto).State = EntityState.Detached;
            }
            return objeto;
        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }

        public T SelecionarPK(params object[] variavel)
        {
            return _Contexto.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return _Contexto.Set<T>().AsNoTracking().ToList();           
        }

        public void Dispose()
        {
            _Contexto.Dispose();
        }
    }
}
