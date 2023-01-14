using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagerAPI.Controllers;

[ApiController]
[Route("Vehicle")]
public class VehicleController : ControllerBase
{

	[HttpGet("Check")]
	public ActionResult<dynamic> Check()
	{
		return true;
	}
    [HttpGet("Get")]
    public ActionResult<dynamic> GetVehicle()
    {

        return new DataContext().Vehicles;
    }
}
