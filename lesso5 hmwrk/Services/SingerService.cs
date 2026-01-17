using lesso5_hmwrk.Models;
using System.Reflection.Metadata.Ecma335;
namespace lesso5_hmwrk.Services;

public class SingerService : IServiceProvider
{
    List<Singer> Singers;

    public SingerService()
    {
        Singers = new List<Singer>();
    }
    public Guid AddSinger(Singer singer)
    {
        singer.Id = Guid.NewGuid();
        Singers.Add(singer);
        return singer.Id;
    }
    public bool DeleteSinger(Guid singerId)
    {
        foreach(var singer in Singers)
        {
            if(singer.Id == singerId)
            {
                Singers.Remove(singer);
                return true;
            }
        }
        return false;
    }
    public bool UpdateSinger(Singer newSingers)
    {
        foreach(Singer singer in Singers)
        {
            if(newSingers.Id == singer.Id)
            {
                singer.Name = newSingers.Name;
                singer.Genre = newSingers.Genre;
                singer.DebutYear = newSingers.DebutYear;
                singer.Coutry = newSingers.Coutry;
                return true;
            }
        }
        return false;
    }
    public List<Singer> GetAllSinger()
    {
        return Singers;
    }

    public Singer? GetByIdSinger(Guid id)
    {
        foreach(var singer in Singers)
        {
            if(singer.Id == id)
            {
                return singer;
            }
        }
        return null;
    }

    public object? GetService(Type serviceType)
    {
        throw new NotImplementedException();
    }
}
