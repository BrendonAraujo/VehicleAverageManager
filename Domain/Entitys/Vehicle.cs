using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entitys;

public class Vehicle
{
    public virtual int Id { get; set; }
    public string Plate { get; set; } = "";
    public float IncialKm { get; set; }
    public float ActuallKm { get; set; }
}