using MediatR;
using Microsoft.EntityFrameworkCore;
using PIC_SocialApp.Application.UserProfiles.Queries;
using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;
using PIC_SocialApp.Infrastructure;

namespace PIC_SocialApp.Application.UserProfiles.QueryHandlers
{
    internal class GetAllUserProfilesHandler : IRequestHandler<GetAllUserProfiles, IEnumerable<UserProfile>>
    {
        private readonly DataContext _context;

        public GetAllUserProfilesHandler(DataContext context)
        {
            _context= context;
        }
        
        public async Task<IEnumerable<UserProfile>> Handle(GetAllUserProfiles request, CancellationToken cancellationToken)
        {
            return await _context.UserProfiles.ToListAsync();
        }
    }
}
