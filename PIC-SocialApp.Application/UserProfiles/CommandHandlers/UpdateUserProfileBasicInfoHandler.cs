using MediatR;
using Microsoft.EntityFrameworkCore;
using PIC_SocialApp.Application.UserProfiles.Commands;
using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;
using PIC_SocialApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC_SocialApp.Application.UserProfiles.CommandHandlers
{
    public class UpdateUserProfileBasicInfoHandler : IRequestHandler<UpdateUserProfileBasicInfo>
    {
        private readonly DataContext _context;

        public UpdateUserProfileBasicInfoHandler(DataContext context)
        {
            _context= context;
        }
        
        public async Task Handle(UpdateUserProfileBasicInfo request, CancellationToken cancellationToken)
        {
            var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileId== request.UserProfileId);
            
            var basicInfo = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName, request.EmailAddress, request.Phone,
                request.DateOfBirth, request.CurrenCity);
            
            userProfile.UpdateBasicInfo(basicInfo);
            _context.UserProfiles.Update(userProfile);
            await _context.SaveChangesAsync();
        }

        //Task IRequestHandler<UpdateUserProfileBasicInfo>.Handle(UpdateUserProfileBasicInfo request, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
