using Domain.Data;
using Domain.Entitys;
using Domain.Repository.Contracts;

namespace Domain.Repository;

public class VehicleRepostory : IVehicleRepository
{
	private DataContext _context;
	public VehicleRepostory()
	{
		_context = new DataContext();
	}
	public Vehicle? GetById(int id)
	{
		return _context.Vehicles.Where(vehicle => vehicle.Id == id).FirstOrDefault();	
	}
	public Vehicle? GetByPlate(string plate)
	{
		return _context.Vehicles.Where(vehicle => vehicle.Plate.Equals(plate)).FirstOrDefault();	
	}
	public List<Vehicle> GetAll()
	{
		return _context.Vehicles.ToList();	
	}

	public void Insert(Vehicle vehicle)
	{
		_context.Vehicles.Add(vehicle);
		_context.SaveChanges();
	}
}