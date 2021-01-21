using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.DataLayer.PleerMusicRepository
{
    public interface IPleerMusicRepository<TEntity>
    {

        void Insert(TEntity entity);

        void Delete(TEntity entity);

        void Delete(object ID);

        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where);

    }
}
