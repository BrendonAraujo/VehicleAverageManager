using Domain.Entitys;

namespace Domain.Repository.Contracts;

public interface ISupplyRepository
{
	Supply? GetById(int id);
	List<Supply> GetByVehiclePlate(string plate);
	void Insert(Supply supply);	
}