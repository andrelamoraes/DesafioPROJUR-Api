using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Domain.Entities;
using Usuarios.Domain.Interfaces;
using Usuarios.Infra.Data.Context;

namespace Usuarios.Infra.Data.Repository
{

    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly SqlServerContext _SqlServerContext;

        public BaseRepository(SqlServerContext SqlServerContext)
        {
            _SqlServerContext = SqlServerContext;
        }

        public void Insert(TEntity obj)
        {
            _SqlServerContext.Set<TEntity>().Add(obj);
            _SqlServerContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _SqlServerContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _SqlServerContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _SqlServerContext.Set<TEntity>().Remove(Select(id));
            _SqlServerContext.SaveChanges();
        }

        public IList<TEntity> Select() =>
            _SqlServerContext.Set<TEntity>().ToList();

        public TEntity Select(int id) =>
            _SqlServerContext.Set<TEntity>().Find(id);

    }
}

