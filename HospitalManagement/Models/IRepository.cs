namespace HospitalManagement.Models
{
    public interface IRepository
    {
        void Update<T>(T entity);
        void Delete<T>(T entity);

    }
}
