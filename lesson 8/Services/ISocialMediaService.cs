using lesson_8.Models;

namespace lesson_8.Services;

public interface ISocialMediaService
{
    public Guid Add(SocialMedia socialMedia);
    public List<SocialMedia> GetAll();
    public SocialMedia? GetById(Guid id);
    public bool Update(Guid id, SocialMedia socialMedia);
    public bool Delete(Guid id);
}
