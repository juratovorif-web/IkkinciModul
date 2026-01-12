using lesson_3.Models;
namespace lesson_3.Service;

public class RestoranService
{
    List<Restoran> Restorans;
    int id = 1;
    public RestoranService()
    {
        Restorans = new List<Restoran>();
    }

    public int AddRestorant(Restoran restoran)
    {
        restoran.Id = id++;
        Restorans.Add(restoran);
        return restoran.Id;
    }

    public Restoran? GetRestoranId(int id)
    {
        foreach(var restoran in Restorans)
        {
            if(restoran.Id == id)
            {
               return restoran;
            }
        }
        return null;
    }

    public bool DeleteRestoran(int id)
    {
        foreach (var restoran in Restorans)
        {
            if (restoran.Id == id)
            {
                Restorans.Remove(restoran);
                return true;
            }
        }
        return false;
    }

    public List<Restoran> GetAllRes()
    {
        return Restorans;
    }

    public bool UpdateRestoran(int resId , Restoran newrestoran)
    {
        var data = GetRestoranId(resId);
        if(data == null)
        {
            return false;
        }

        data.RestoranName = newrestoran.RestoranName;
        data.MenuRestorant = newrestoran.MenuRestorant;
        data.Capacity = newrestoran.Capacity;
        data.Address = newrestoran.Address;
        data.WorkingPerople = newrestoran.WorkingPerople;
        
        return true;
    }
}
