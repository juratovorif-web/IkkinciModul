
using lesson_3.Models;

namespace lesson_3.Service;

public class ClosetService
{
    List<Closet> Closets = new List<Closet>();

    public Guid AddCloset(Closet closet)
    {
        closet.Id = Guid.NewGuid();
        Closets.Add(closet);
        return closet.Id;
    }

    public Closet? GetByIdCloset(Guid id)
    {
        foreach (var closet in Closets)
        {
            if (closet.Id == id)
            {
                return closet;
            }
        }
        return null;
    }

    public bool DeleteCloset(Guid closetId)
    {
        var closet = GetByIdCloset(closetId);
        if (closet == null)
        {

            return false;
        }
        Closets.Remove(closet);
        return true;
    }

    public List<Closet> GetAllClosets()
    {
        return Closets;
    }

    public bool UpdateCloset(Guid closetId, Closet newCloset)
    {
        var closet = GetByIdCloset(closetId);
        if (closet == null)
        {
            return false;
        }
        closet.Brend = newCloset.Brend;
        closet.Material = newCloset.Material;
        closet.Color = newCloset.Color;
        closet.Price = newCloset.Price;

        return true;
    }
}
