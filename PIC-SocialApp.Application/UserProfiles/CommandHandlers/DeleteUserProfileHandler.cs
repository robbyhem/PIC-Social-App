using MediatR;
using Microsoft.EntityFrameworkCore;
using PIC_SocialApp.Application.UserProfiles.Commands;
using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;
using PIC_SocialApp.Infrastructure;

namespace PIC_SocialApp.Application.UserProfiles.CommandHandlers
{
    public class DeleteUserProfileHandler : IRequestHandler<DeleteUserProfile>
    {
        private readonly DataContext _context;

        public DeleteUserProfileHandler(DataContext context)
        {
            _context= context;
        }
        
        public async Task Handle(DeleteUserProfile request, CancellationToken cancellationToken)
        {
            var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileId == request.UserProfileId);
            _context.UserProfiles.Remove(userProfile);
            await _context.SaveChangesAsync();
        }
    }
}
