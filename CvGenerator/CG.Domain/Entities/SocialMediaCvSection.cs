namespace CG.Domain.Entities
{
    public class SocialMediaCvSection : Entity
    {
        public CvSection CvSection { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}
