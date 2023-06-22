using MediatR;
using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;

namespace PIC_SocialApp.Application.UserProfiles.Queries
{
    public class GetAllUserProfiles : IRequest<IEnumerable<UserProfile>>
    {
    }
}
