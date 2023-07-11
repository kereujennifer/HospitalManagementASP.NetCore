using HospitalManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    public class Repository : IRepository
    {
        private readonly ApplicationDBContext dbContext;

        public Repository(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update<T>(T entity)
        {
            dbContext.Update(entity);
            dbContext.SaveChanges();
        }

        public void Delete<T>(T entity)
        {
            dbContext.Remove(entity);
            dbContext.SaveChanges();
        }
    }
}
