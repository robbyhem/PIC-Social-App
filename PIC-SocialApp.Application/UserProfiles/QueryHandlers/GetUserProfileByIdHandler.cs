using MediatR;
using Microsoft.EntityFrameworkCore;
using PIC_SocialApp.Application.UserProfiles.Queries;
using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;
using PIC_SocialApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC_SocialApp.Application.UserProfiles.QueryHandlers
{
    internal class GetUserProfileByIdHandler : IRequestHandler<GetuserProfileById, UserProfile>
    {
        private readonly DataContext _context;

        public GetUserProfileByIdHandler(DataContext context)
        {
            _context= context;
        }
        
        public async Task<UserProfile> Handle(GetuserProfileById request, CancellationToken cancellationToken)
        {
            return await _context.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileId == request.UserProfileId);
            //return await _context.UserProfiles.FindAsync(request.UserProfileId);
        }
    }
}
