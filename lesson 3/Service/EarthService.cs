using lesson_3.Models;

namespace lesson_3.Service;

internal class EarthService
{
    List<Earth> Earths;
    public EarthService()
    {
        Earths = new List<Earth>();
    }

    public Guid AddEarth(Earth earth)
    {
        earth.EarthId = Guid.NewGuid();
        Earths.Add(earth);
        return earth.EarthId;
    }
    public Earth? GetByEarthId(Guid earthId)
    {
        foreach (var earth in Earths)
        {
            if (earth.EarthId == earthId)
            {
                return earth;
            }
        }
        return null;
    }
    public bool DeleteEarth(Guid earthId)
    {
        foreach (var earth in Earths)
        {
            if (earth.EarthId == earthId)
            {
                Earths.Remove(earth);
                return true;
            }
        }
        return false;   
    }
    public List<Earth> GetAllEarths()
    {
        return Earths;
    }
    public bool UpdateEarth(Guid earthId, Earth newEarth)
    {
        for(var i = 0; i < Earths.Count; i++)
        {
            if (Earths[i].EarthId == earthId)
            {
                Earths[i].Countries = newEarth.Countries;
                Earths[i].Volume = newEarth.Volume;
                Earths[i].Population = newEarth.Population;
                Earths[i].IsDeveloped = newEarth.IsDeveloped;
                return true;
            }
        }
        return false;
    }

    public void GetString(Earth data)
    {
        Console.WriteLine(data.Countries);
        Console.WriteLine(data.Volume);
        Console.WriteLine(data.Population);
        Console.WriteLine(data.IsDeveloped);
    }

}
