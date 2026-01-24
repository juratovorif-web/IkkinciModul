using lesson_8.Models;

namespace lesson_8.Services;

public class SMAwsService : ISocialMediaService
{
    List<SocialMedia> SocialMedias = new List<SocialMedia>();
    public Guid Add(SocialMedia socialMedia)
    {
       socialMedia.SocialMediaId = Guid.NewGuid();
        SocialMedias.Add(socialMedia);
        return socialMedia.SocialMediaId;
    }

    public bool Delete(Guid id)
    {
        foreach(var sM in SocialMedias )
        {
            if( sM.SocialMediaId == id )
            {
                SocialMedias.Remove( sM );
                return true;
            }
        }
        return false;
    }

    public List<SocialMedia> GetAll()
    {
       return SocialMedias;
    }

    public SocialMedia? GetById(Guid id)
    {
        foreach( var sM in SocialMedias )
        {
            if(sM.SocialMediaId == id )
            {
                return sM;
            }
        }
        return null;
    }

    public bool Update(Guid id, SocialMedia newSocialMedia)
    {
        foreach(var sM in SocialMedias)
        {
            if(sM.SocialMediaId == id )
            {
                sM.Name = newSocialMedia.Name;
                sM.Description = newSocialMedia.Description;
                sM.Ceo = newSocialMedia.Ceo;
                return true;
            }
        }
        return false;
    }
}
