using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;

namespace PIC_SocialApp.Api.Contracts.UserProfileContract.Responses
{
    public record UserProfileResponse
    {
        public Guid UserProfileId { get; set; }
        public BasicInfoResponse BasicInfo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
