using Dapper;
using Domein.Models;
using Infrastructure.DataContext;
using Infrastructure.Interface;

namespace Infrastructure.Services;

public class StudentServices: ICrudServices<Student>
{
    readonly DapperContext _context;

    public StudentServices()
    {
        _context = new DapperContext();
    }


    public List<Student> GetAll()
    {
        var sql = @"select * from Student";
        var res = _context.GetConnection().Query<Student>(sql).ToList();
        return res;
    }

    public Student GetById(int id)
    {
        var sql = @"select * from Student where Id = @Id";
        var res = _context.GetConnection().QueryFirstOrDefault<Student>(sql, new { Id = id });
        return res;
    }

    public bool Add(Student entity)
    {
        var sql = @"insert into Student(student_code,student_full_name,gender,dob,email,phone,school_id,stage,section,is_active,join_date,created_at,udated_at)
values(@student_code, @student_full_name, @gender, @dob, @email, @phone, @school_id, @stage, @section, @is_active, @join_date, @created_at, @udated_at) ";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Update(Student entity)
    {
        var sql = "udate Student set student_code=@student_code, student_full_name=@student_full_name, gender=@gender, gender=@gender, email=@email, phone=@phone, school_id=@school_id, stage=@stage, section=@section, is_active=@is_active, join_date=@join_date, created_at=@created_at";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Delete(Student entity)
    {
        var sql = "delete from Student where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }
}