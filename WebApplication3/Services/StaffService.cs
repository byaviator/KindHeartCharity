using KindHeartCharity.Contexts;
using KindHeartCharity.Models;

namespace KindHeartCharity.Services;

public class StaffService
{
    private readonly AppDbContext _appDbContext;
    public StaffService()
    {
        _appDbContext = new AppDbContext();
    }
    public List<StaffModel> GetAllStaff()
    {
        return  _appDbContext.StaffModel.ToList(); 
    }


}
