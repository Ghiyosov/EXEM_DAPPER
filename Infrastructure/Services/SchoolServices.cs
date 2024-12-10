using Dapper;
using Infrastructure.DataContext;
using Infrastructure.Interface;

namespace Infrastructure.Services;

public class SchoolServices : ICrudServices<SchoolServices>
{
    readonly DapperContext _context;

    public SchoolServices()
    {
        _context = new DapperContext();
    }

    public List<SchoolServices> GetAll()
    {
        var sql = "select * from School";
        var res = _context.GetConnection().Query<SchoolServices>(sql).ToList();
        return res;
    }

    public SchoolServices GetById(int id)
    {
        var sql = "select * from School where Id = @Id";
        var res = _context.GetConnection().QueryFirstOrDefault<SchoolServices>(sql, new { Id = id });
        return res;
    }

    public bool Add(SchoolServices entity)
    {
        var sql = "insert into School (title,level_count,is_active,created_at,updated_at) values (@Title,@LevelCount,@IsActive,@CreatedAt,@UpdatedAt)";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Update(SchoolServices entity)
    {
        var sql = "Update School set title=@title, level_count=@level_count, is_active=@is_active, updated_at=@updated_at where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }

    public bool Delete(SchoolServices entity)
    {
        var sql = "delete from School where Id = @Id";
        var res = _context.GetConnection().Execute(sql, entity);
        return res > 0;
    }
}