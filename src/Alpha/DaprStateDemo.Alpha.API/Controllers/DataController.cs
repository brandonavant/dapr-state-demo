using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DaprStateDemo.Alpha.API.Models;

namespace DaprStateDemo.Alpha.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataController : ControllerBase
{
  private readonly ILogger<DataController> _logger;
  private readonly List<Data> _data;

  public DataController(ILogger<DataController> logger)
  {
    _logger = logger;
    _data = new List<Data> { new Data { Id = Guid.NewGuid(), Value = "Meh" } };
  }

  [HttpGet]
  public async Task<List<Data>> RetrieveData()
  {
    return _data;
  }
}
