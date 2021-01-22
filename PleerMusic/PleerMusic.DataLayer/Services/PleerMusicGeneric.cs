using PleerMusic.DataLayer.Context;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.DataLayer.Services
{
    public class PleerMusicGeneric<TEntity> where TEntity : class
    {

        private PleerMusicDB _Db;
        private DbSet<TEntity> _DbSet;

        public PleerMusicGeneric(PleerMusicDB Db)
        {
            _Db = Db;
            _DbSet = Db.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null, params string[] include)
        {

            IQueryable<TEntity> query = _DbSet;

            if (where != null)
            {
                query = query.Where(where);
            }
            if (include.Length != 0)
            {
                for (int i = 0; i < include.Length; i++)
                {
                    var a = query.Include(include[i]).ToList();
                    query = query.Include(include[i]);
                }

            }



            return query.ToList();

        }

        public TEntity GetById(object ID)
        {
            return _DbSet.Find(ID);
        }


        public void Insert(TEntity entity)
        {

            attaching(entity);

            _Db.Entry(entity).State = EntityState.Added;

        }

        public void Delete(TEntity entity)
        {
            attaching(entity);

            _Db.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(object ID)
        {

            TEntity res = GetById(ID);

            Delete(res);

        }
        private void attaching(TEntity entity)
        {
            if (_Db.Entry(entity).State == EntityState.Detached)
            {
                _DbSet.Attach(entity);
            }

        }
    }


}
