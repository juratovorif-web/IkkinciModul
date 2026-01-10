using lesson_3.Models;
namespace lesson_3.Service;

public class HomeService
{
    List<Home> Homes;
    public HomeService()
    {
        Homes = new List<Home>();
    }
    public Guid AddHome(Home home)
    {
        home.HomeId = Guid.NewGuid();
        Homes.Add(home);
        return home.HomeId;
    }
    public Home? GetByHomeId(Guid homeId)
    {
        foreach (var home in Homes)
        {
            if (home.HomeId == homeId)
            {
                return home;
            }    
        }
        return null;
    }
    public bool DeleteHome(Guid homeId)
    {
        foreach(var home in Homes)
        {
            if(home.HomeId == homeId)
            {
                Homes.Remove(home);
                return true;
            }
        }
        return false;
    }
    public List<Home> GetAllHomes()
    {
        return Homes;
    }
    public bool UpdateHome(Guid homeId, Home newHome)
    {
        for(var i =  0; i < Homes.Count; i++)
        {
            if (Homes[i].HomeId == homeId)
            {
                Homes[i].HomeNum = newHome.HomeNum;
                Homes[i].Location = newHome.Location;
                Homes[i].HomeRoomNum = newHome.HomeRoomNum;
                Homes[i].KvHouse = newHome.KvHouse;
                Homes[i].PriceHom = newHome.PriceHom;
                return true;
            }
        }
        return false;
    }

}
