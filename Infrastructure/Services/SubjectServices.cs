using Dapper;
using Domein.Models;
using Infrastructure.DataContext;
using Infrastructure.Interface;

namespace Infrastructure.Services;

public class SubjectServices: ICrudServices<Subject>
{
    readonly DapperContext _context;

    public SubjectServices()
    {
        _context = new DapperContext();
    }


    public List<Subject> GetAll()
    {
        string sql = "select * from Subject";
        var res = _context.GetConnection().Query<Subject>(sql).ToList();
        return res;
    }

    public Subject GetById(int id)
    {
        var sql = "select * from Subject where Id = @Id";
        var res = _context.GetConnection().QueryFirstOrDefault<Subject>(sql, new { Id = id });
        return res;
    }

    public bool Add(Subject entity)
    {
        var sql = "insert into Subject(title,school_id,stage,term,carry_mark,created_at,updated_at) values(@title,@school_id,@stage,@term,@carry_mark,@created_at,@updated_at)";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Update(Subject entity)
    {
        var sql = "update Subject set title=@title, school_id=@school_id, stage=@stage, term=@term, carry_mark=@carry_mark, updated_at=@updated_at where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Delete(Subject entity)
    {
        var sql = "delete from Subject where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }
}