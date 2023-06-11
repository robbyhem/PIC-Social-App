using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC_SocialApp.Domain.Assembly.UserProfileAssembly
{
    public class UserProfile
    {
        private UserProfile() { }
        
        public Guid UserProfileId { get; private set; }
        public string IdentityId { get; private set; }
        public BasicInfo BasicInfo { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime LastUpdated { get; private set; }

        public static UserProfile CreateUserProfile(string identityId, BasicInfo basicInfo)
        {
            // To Do: add validations, error handling strategies, error notification strategies

            return new UserProfile
            {
                IdentityId = identityId,
                BasicInfo = basicInfo,
                CreatedAt = DateTime.UtcNow,
                LastUpdated= DateTime.UtcNow

            };
        }

        public void UpdateBasicInfo(BasicInfo newInfo)
        {
            BasicInfo= newInfo;
            LastUpdated= DateTime.UtcNow;
        }
    }
}
