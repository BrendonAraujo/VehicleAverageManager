using Domain.Entitys;

namespace Domain.Repository.Contracts;

public interface IVehicleRepository
{
	Vehicle? GetById(int id);
	Vehicle? GetByPlate(string plate);
	List<Vehicle> GetAll();
	void Insert(Vehicle vehicle);
}