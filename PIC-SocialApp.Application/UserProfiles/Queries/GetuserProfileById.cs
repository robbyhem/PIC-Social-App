using MediatR;
using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC_SocialApp.Application.UserProfiles.Queries
{
    public class GetuserProfileById : IRequest<UserProfile>
    {
        public Guid UserProfileId { get; set; }
    }
}
