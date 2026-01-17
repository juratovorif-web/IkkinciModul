using lesso5_hmwrk.Models;
namespace lesso5_hmwrk.Services;

public interface ISingerService
{
    public Guid AddSinger(Singer singer);
    public List<Singer> GetAllSinger();
    public bool UpdateSinger(Singer singer);
    public bool DeleteSinger(Guid singerId);
    public Singer? GetByIdSinger(Guid singerId);

}
