using lesson_6.Models;
using lesson_6.Dtos;
using System.Reflection.Metadata.Ecma335;

namespace lesson_6.Services;

public class SingerService : ISingerService
{

    List<Singer> Singers;
    public SingerService()
    {
        Singers = new List<Singer>();
    }
    public Guid AddSinger(SingerCreateDto singerCreateDto)
    {
        var singer = new Singer()
        {
            SingerId = Guid.NewGuid(),
            FirstName = singerCreateDto.FirstName,
            LastName = singerCreateDto.LastName,
            SingerName = singerCreateDto.SingerName,
            Password = singerCreateDto.Password,
            MusicName = singerCreateDto.MusicName,
            Genres = singerCreateDto.Genres,
            Awards = singerCreateDto.Awards,
            TotalPlays = 0
        };
        Singers.Add(singer);
        return singer.SingerId;
    }

    public bool DeleteSinger(Guid singerId)
    {
        foreach(var singer in Singers)
        {
            if(singer.SingerId == singerId)
            {
                Singers.Remove(singer);
                return true;
            }
        }
        return false;
    }

    public List<SingerGetDto> GetAllSingers()
    {
       var singerGetDtos = ToSingerGetDtos(Singers);
        return singerGetDtos;
    }

    public SingerGetDto?GetSingerById(Guid singerId)
    {
        foreach(var singer in Singers)
        {
            if(singer.SingerId == singerId)
            {
                return ToSingerGetDto(singer);
            }
        }
       return null;
    }

    public List<SingerGetDto> GetSingersByGenre(string genre)
    {
        var singerGetDtos = new List<SingerGetDto>();
        foreach(var singer in Singers)
        {
            if(singer.Genres.Contains(genre))
            {
                singerGetDtos.Add(ToSingerGetDto(singer));
            }
        }
        return singerGetDtos;

    }

    public SingerGetDto? GetSingerWithMaxAward()
    {
        //var singer = Singers.Max(s => s.Awards);

        if(Singers.Count == 0)
        {
            return null;
        }
        var singerWithMaxAward = Singers[0];
        foreach(var singer in Singers)
        {
            if(singerWithMaxAward.Awards.Count() > singer.Awards.Count())
            {
                singerWithMaxAward = singer;
            }
        }
        return ToSingerGetDto(singerWithMaxAward);
    }

    
    public SingerGetDto? GetSingerWithMaxMusic()
    {
        if(Singers.Count == 0)
        {
            return null;
        }
        var singerWithMaxMusic = Singers[0];
        foreach(var singer in Singers)
        {
            if(singerWithMaxMusic.MusicName.Count() < singer.MusicName.Count())
            {
                 singerWithMaxMusic = singer;
            }
        }
        return ToSingerGetDto(singerWithMaxMusic);
    }

    public SingerGetDto? GetSingerWithMaxPlays()
    {
        if(Singers.Count == 0)
        {
            return null;
        }
        var singerWithMaxPlays = Singers[0];    
        foreach( var singer in Singers)
        {
            if (singerWithMaxPlays.TotalPlays < singer.TotalPlays)
            {
                singerWithMaxPlays = singer;    
            }
        }
        return ToSingerGetDto(singerWithMaxPlays);
    }

    SingerGetDto? GetSingerWithMinAward()
    {
        if(Singers.Count() == 0)
        {
            return null ;
        }
        var singerWithMinAward = Singers[0];
        foreach( var singer in Singers)
        {
            if (singerWithMinAward.Awards.Count() > singer.Awards.Count())
            {
                singerWithMinAward = singer;
            }
        }
        return ToSingerGetDto(singerWithMinAward);
    }

    public SingerGetDto? GetSingerWithMinMusic()
    {
        if(Singers.Count() == 0)
        {
            return null ;
        }
        var singerWithMinMusic = Singers[0];
        foreach(var singer in Singers)
        {
            if(singerWithMinMusic.MusicName.Count() > singer.MusicName.Count())
            {
                singerWithMinMusic = singer;
            }
        }
        return ToSingerGetDto(singerWithMinMusic);
    }

    public SingerGetDto? GetSingerWithMinPlays()
    {
        if(Singers.Count()==0)
        {
            return null;
        }
        var singerWithMinPlays = Singers[0];
        foreach(var singer in Singers)
        {
            if(singerWithMinPlays.TotalPlays > singer.TotalPlays)
            {
                singerWithMinPlays = singer;
            }
        }
        return ToSingerGetDto(singerWithMinPlays);
    }

    public List<SingerGetDto> GetTopSingersWithMaxPlays(int count, List<Singer> singers)
    {
        for (var i = 0; i < Singers.Count(); i++)
        {
            var singerWithMaxPlays = Singers[i];
            var index = i;
            for (var j = i + 1; j < Singers.Count(); j++)
            {
                if (singerWithMaxPlays.TotalPlays < Singers[j].TotalPlays)
                {
                    singerWithMaxPlays = Singers[j];
                    index = j;
                }
            }

            var swapSinger = Singers[index];
            Singers[index] = Singers[i];
            Singers[i] = swapSinger;
        }

        var topSingers = new List<Singer>();

        for (var i = 0; i < count; i++)
        {
            topSingers.Add(Singers[i]);
        }

        return ToSingerGetDtos(topSingers);
    }

    

    public List<SingerGetDto> GetTopSingersWithMinPlays(int count)
    {
        for (var i = 0; i < Singers.Count(); i++)
        {
            var singerWithMinPlays = Singers[i];
            var index = i;
            for (var j = i + 1; j < Singers.Count(); j++)
            {
                if (singerWithMinPlays.TotalPlays > Singers[j].TotalPlays)
                {
                    singerWithMinPlays = Singers[j];
                    index = j;
                }
            }

            var swapSinger = Singers[index];
            Singers[index] = Singers[i];
            Singers[i] = swapSinger;
        }

        var minSingers = new List<Singer>();

        for (var i = 0; i < count; i++)
        {
            minSingers.Add(Singers[i]);
        }

        return ToSingerGetDtos(minSingers);
    }
    

    public bool UpdateSinger(Guid singerId, SingerUpdateDto singerUpdateDto)
    {
        foreach (var singer in Singers)
        {
            if (singer.SingerId == singerId)
            {
                singer.FirstName = singerUpdateDto.FirstName;
                singer.LastName = singerUpdateDto.LastName;
                singer.SingerName = singerUpdateDto.SingerName;
                singer.Awards = singerUpdateDto.Awards;
                singer.Password = singerUpdateDto.Password;
                singer.MusicName = singerUpdateDto.MusicName;
                singer.Genres = singerUpdateDto.Genres;
                return true;
            }
        }

        return false;
    }
    



    private SingerGetDto ToSingerGetDto(Singer singer)
    {
        return new SingerGetDto()
        {
            SingerId = singer.SingerId,
            FirstName = singer.FirstName,
            LastName = singer.LastName,
            SingerName = singer.SingerName,
            MusicNames = singer.MusicName,
            Genres = singer.Genres,
            Awards = singer.Awards,
            TotalPlays = singer.TotalPlays,
        };
    }
    private List<SingerGetDto> ToSingerGetDtos(List<Singer> singers)
    {
        var singerGetDtos = new List<SingerGetDto>();
        foreach (var singer in singers)
        {
            singerGetDtos.Add(ToSingerGetDto(singer));
        }
        return singerGetDtos;
    }
}

