using Dapper;
using Domein.Models;
using Infrastructure.DataContext;
using Infrastructure.Interface;

namespace Infrastructure.Services;

public class Class_StudentServices : ICrudServices<Class_Student>
{
    readonly DapperContext _context;

    public Class_StudentServices()
    {
        _context = new DapperContext();
    }

    public List<Class_Student> GetAll()
    {
        var sql = "select * from Class_Student";
        var res = _context.GetConnection().Query<Class_Student>(sql).ToList();
        return res;
    }

    public Class_Student GetById(int id)
    {
        var sql = "select * from Class_Student where id=@Id";
        var res = _context.GetConnection().QueryFirstOrDefault<Class_Student>(sql, new { Id=id });
        return res;
    }

    public bool Add(Class_Student entity)
    {
        var sql = "insert into Class_Student (class_id,student_id) values (@class_id,@student_id)";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Update(Class_Student entity)
    {
        var sql = "update Class_Student set class_id=@class_id,student_id=@student_id where class_student_id=@class_student_id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Delete(Class_Student entity)
    {
        var sql = "delete from Class_Student where class_student_id=@class_student_id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }
}