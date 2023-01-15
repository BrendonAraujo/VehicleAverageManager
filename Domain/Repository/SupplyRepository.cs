using Domain.Data;
using Domain.Entitys;
using Domain.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository;

public class SupplyRepository : ISupplyRepository
{
	private DataContext _context;
	public SupplyRepository()
	{
		_context = new DataContext();
	}

	public Supply? GetById(int id)
	{
		return _context.Supplies.Where(supply => supply.Id == id)
			.Include(supply => supply.Vehicle)
			.FirstOrDefault();
	}

	public List<Supply> GetByVehiclePlate(string plate)
	{
		
		return _context.Supplies
			.Where(supply => supply.Vehicle.Plate == plate)
			.Include(supply => supply.Vehicle)
			.ToList();
	}

    public void Insert(Supply supply)
    {
        _context.Supplies.Add(supply);
		_context.SaveChanges();
    }
}