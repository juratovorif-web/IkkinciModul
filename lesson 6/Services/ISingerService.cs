using lesson_6.Models;
using lesson_6.Dtos;

namespace lesson_6.Services
{
    public interface ISingerService
    {
        public Guid AddSinger(SingerCreateDto singerCreateDto);
        public SingerGetDto? GetSingerById(Guid singerId);
        public List<SingerGetDto> GetAllSingers();
        public bool DeleteSinger(Guid singerId);
        public bool UpdateSinger(Guid singerId , SingerUpdateDto singerUpdateDto);
        public SingerGetDto? GetSingerWithMaxPlays();
        public SingerGetDto? GetSingerWithMaxMusic();
        public SingerGetDto? GetSingerWithMaxAward();
        public SingerGetDto? GetSingerWithMinPlays();
        public SingerGetDto? GetSingerWithMinMusic();
        public SingerGetDto? GetSingerWithMinAward();
        public List<SingerGetDto> GetTopSingersWithMaxPlays(int count);
        public List<SingerGetDto> GetTopSingersWithMinPlays(int count);
        public List<SingerGetDto> GetSingersByGenre(string genre);
    }
}