using Dapper;
using Domein.Models;
using Infrastructure.DataContext;
using Infrastructure.Interface;

namespace Infrastructure.Services;

public class ClassService:ICrudServices<Class>
{
    readonly DapperContext _context;

    public ClassService()
    {
        _context = new DapperContext();
    }


    public List<Class> GetAll()
    {
        var sql = "select * from Class";
        var res = _context.GetConnection().Query<Class>(sql).ToList();
        return res;
    }

    public Class GetById(int id)
    {
        var sql = "select * from Class where Id = @Id";
        var res = _context.GetConnection().QueryFirstOrDefault<Class>(sql, new { Id = id });
        return res;
    }

    public bool Add(Class entity)
    {
        var sql = "insert into Class (class_name,subject_id,teacher_id,classroom_id,section,created_at,updated_at) values (@Class_name,@Subject_id,@teacher_id,@Classroom_id,@Section,@Created_At,@Updated_At)";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Update(Class entity)
    {
        var sql = "update  Class set class_name=@Class_name, subject_id=@Subject_id, teacher_id=@Teacher_id, classroom_id=@Classroom_id, section=@Section, updated_at=@Updated_At where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res>0;
    }

    public bool Delete(Class entity)
    {
        var sql = "delete from Class where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }
}