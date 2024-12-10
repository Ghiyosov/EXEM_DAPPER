using Dapper;
using Domein.Models;
using Infrastructure.DataContext;
using Infrastructure.Interface;

namespace Infrastructure.Services;

public class ParentServices: ICrudServices<Parent>
{
    readonly DapperContext _context;

    public ParentServices()
    {
        _context = new DapperContext();
    }

    public List<Parent> GetAll()
    {
        var sql = @"select * from Parent";
        var res = _context.GetConnection().Query<Parent>(sql).ToList();
        return res;
    }

    public Parent GetById(int id)
    {
        var sql = @"select * from Parent where Id = @Id";
        var res = _context.GetConnection().QueryFirstOrDefault<Parent>(sql, new { Id = id });
        return res;
    }

    public bool Add(Parent entity)
    {
        var sql = @"insert into Parent (parent_code,parent_full_name,email,phone,created_at,updated_at) values (@parent_code, @parent_full_name, @email, @phone, @created_at, @updated_at)";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Update(Parent entity)
    {
        var sql = "Update parent set parent_code=@parent_code, parent_full_name=@parent_full_name, email=@email, phone=@phone, updated_at=@updated_at where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Delete(Parent entity)
    {
        var sql = "delete from Parent where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }
}