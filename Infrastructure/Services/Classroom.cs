using Dapper;
using Infrastructure.DataContext;
using Infrastructure.Interface;

namespace Infrastructure.Services;

public class Classroom : ICrudServices<Classroom>
{
    readonly DapperContext _context;

    public Classroom()
    {
        _context = new DapperContext();
    }


    public List<Classroom> GetAll()
    {
        var sql = @"select * from Classroom";
        var res = _context.GetConnection().Query<Classroom>(sql).ToList();
        return res;
    }

    public Classroom GetById(int id)
    {
        var sql = @"select * from Classroom where Id = @Id";
        var res = _context.GetConnection().QueryFirstOrDefault<Classroom>(sql, new { Id = id });
        return res;
    }

    public bool Add(Classroom entity)
    {
        var sql = @"insert into Classroom (class_name,teacher_id,classroom_id,section,created_at,updated_at) values (@class_name,@teacher_id,@classroom_id,@section,@created_at,@updated_at)";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Update(Classroom entity)
    {
        var sql = "Update Classroom set class_name=@class_name, subject_id=@subject_id, teacher_id=@teacher_id, classroom_id=@classroom_id, section=@section, updated_at=@updated_at where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Delete(Classroom entity)
    {
        var sql = @"delete from Classroom where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }
}