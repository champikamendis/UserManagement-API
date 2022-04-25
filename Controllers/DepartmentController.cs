namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApi.Helpers;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class DepartmentsController : ControllerBase
{
    private IDepartmentService _departmentService;
    private IMapper _mapper;
    private readonly AppSettings _appSettings;

    public DepartmentsController(
        IDepartmentService departmentService,
        IMapper mapper,
        IOptions<AppSettings> appSettings)
    {
        _departmentService = departmentService;
        _mapper = mapper;
        _appSettings = appSettings.Value;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var departments = _departmentService.GetAll();
        return Ok(departments);
    }
}
