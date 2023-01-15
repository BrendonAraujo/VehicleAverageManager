namespace Domain.Models.Requests;

public class AddSupplyRequest
{
	public virtual int? VehicleId { get; set; }
	public virtual float Km { get; set; }
	public virtual float Quantity { get; set; }
	public virtual DateTime Date { get; set; } = DateTime.Now;
	public virtual float Value  { get; set; }
}