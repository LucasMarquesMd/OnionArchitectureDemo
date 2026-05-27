using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfrastructureLayer.Repositories.Interfaces
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
