using Dapper;
using Domein.Models;
using Infrastructure.DataContext;
using Infrastructure.Interface;

namespace Infrastructure.Services;

public class Student_ParentServices: ICrudServices<Student_Parent>
{
    readonly DapperContext _context;

    public Student_ParentServices()
    {
        _context = new DapperContext();
    }

    public List<Student_Parent> GetAll()
    {
        var sql = @"select * from Student_Parent";
        var res = _context.GetConnection().Query<Student_Parent>(sql).ToList();
        return res;
    }

    public Student_Parent GetById(int id)
    {
        var sql = @"select * from Student_Parent where Student_ParentId = @Student_ParentId";
        var res = _context.GetConnection().QueryFirstOrDefault<Student_Parent>(sql, new { Student_ParentId = id });
        return res;
    }

    public bool Add(Student_Parent entity)
    {
        var sql = "insert into Student_Parent (student_id,parent_id,relationship) values (@student_id,@parent_id,@relationship)";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Update(Student_Parent entity)
    {
        var sql = "update Student_Parent set student_id=@student_id, parent_id=@parent_id, relationship=@relationship where Student_ParentId = @Student_ParentId";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Delete(Student_Parent entity)
    {
        var sql = "delete from Student_Parent where Student_ParentId = @Student_ParentId";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }
}