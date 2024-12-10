namespace Infrastructure.Interface;

public interface ICrudServices<T>
{
    List<T> GetAll();
    T GetById(int id);
    bool Add(T entity);
    bool Update(T entity);
    bool Delete(T entity);
}