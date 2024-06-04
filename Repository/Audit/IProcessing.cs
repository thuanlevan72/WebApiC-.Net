using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Audit
{
    public interface IProcessing<TEntity> where TEntity : class
    {
        void OnCreating(TEntity entity);
        void OnReading(TEntity entity);
        void OnUpdating(TEntity entity);
        void OnDeleting(TEntity entity);
    }
}
