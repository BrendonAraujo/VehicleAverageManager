using Domain.Entitys;
using Domain.Repository;
using Domain.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ManagerAPI.Controllers;

[ApiController]
[Route("Vehicle")]
public class VehicleController : ControllerBase
{
	private IVehicleRepository _vehicleRepository; 
	public VehicleController()
	{
        _vehicleRepository = new VehicleRepostory();
	}

	[HttpGet("Check")]
	public ActionResult<bool> Check()
	{
        this.Response.Headers.AccessControlAllowOrigin = "*";
        return true;
	}

	[HttpGet("Get/{vehiclePlate}")]
	public ActionResult<Vehicle?> GetVehicle(string vehiclePlate)
	{
        this.Response.Headers.AccessControlAllowOrigin = "*";
        return _vehicleRepository.GetByPlate(vehiclePlate);
	}

	[HttpGet("GetAll")]
	public ActionResult<List<Vehicle>> GetVehicle()
	{
        this.Response.Headers.AccessControlAllowOrigin = "*";
        var a =_vehicleRepository.GetAll(); 
		return a;
		
	}
}
