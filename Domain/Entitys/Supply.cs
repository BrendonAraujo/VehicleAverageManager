using Domain.Models.Requests;

namespace Domain.Entitys;

public  class Supply
{
	public virtual int Id { get; set; }
	public virtual int? VehicleId { get; set; }
	public virtual Vehicle? Vehicle { get; set; }
	public virtual float Km { get; set; }
	public virtual float Quantity { get; set; }
	public virtual DateTime Date { get; set; }
	public virtual float Value  { get; set; }
	
	public static implicit operator AddSupplyRequest(Supply supply)
	{
		AddSupplyRequest supplyRequest = new AddSupplyRequest();
		supplyRequest.VehicleId = supply.VehicleId;
		supplyRequest.Km = supply.Km;
		supplyRequest.Quantity = supply.Quantity;
		supplyRequest.Date = supply.Date;
		supplyRequest.Value = supply.Value;
		return supplyRequest;
	}
	
	public static implicit operator Supply(AddSupplyRequest supplyRequest)
	{
		Supply supply = new Supply();
		supply.VehicleId = supplyRequest.VehicleId;
		supply.Km = supplyRequest.Km;
		supply.Quantity = supplyRequest.Quantity;
		supply.Date = supplyRequest.Date;
		supply.Value = supplyRequest.Value;
		return supply;
	}
}