namespace WebApi.Services;

using AutoMapper;
using WebApi.Entities;
using WebApi.Helpers;

public interface IDepartmentService
{
    IEnumerable<Department> GetAll();
}

public class DepartmentService : IDepartmentService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public DepartmentService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Department> GetAll()
    {
        return _context.Departments;
    }
}