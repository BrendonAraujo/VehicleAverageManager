using Domain.Entitys;
using Domain.Models.Requests;
using Domain.Repository;
using Domain.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ManagerAPI.Controllers;

[ApiController]
[Route("Supply")]
public class SupplyController : ControllerBase
{
	private ISupplyRepository _supplyRepository;
	public SupplyController()
	{
		_supplyRepository = new SupplyRepository();
	}

	[HttpGet("Check")]
	public ActionResult<bool> Check()
	{
        this.Response.Headers.AccessControlAllowOrigin = "*";
        return true;
	}
	
	[HttpGet("Get/{supplyId}")]
	public ActionResult<Supply?> GetSupply(int supplyId)
	{
        this.Response.Headers.AccessControlAllowOrigin = "*";
        return _supplyRepository.GetById(supplyId);
	}
		
	[HttpGet("GetByPlate/{vehiclePlate}")]
	public ActionResult<List<Supply>> GetSupllyByVehicle(string vehiclePlate)
	{
        this.Response.Headers.AccessControlAllowOrigin = "*";
        return _supplyRepository.GetByVehiclePlate(vehiclePlate);
	}
	
	[HttpPost("Add")]
	public ActionResult<bool> AddSupply(AddSupplyRequest supply)
	{
        this.Response.Headers.AccessControlAllowOrigin = "*";
        try
		{
			_supplyRepository.Insert(supply);
			return true;	
		}catch
		{
			return false;
		}
	}
}
