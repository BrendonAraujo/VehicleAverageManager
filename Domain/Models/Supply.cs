namespace Domain.Models;

public  class Supply
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    //public Vehicle Vehicle { get; set; }
    public float Km { get; set; }
    public float Quantity { get; set; }
    public DateTime Date{ get; set; }
    public float Value  { get; set; }
}