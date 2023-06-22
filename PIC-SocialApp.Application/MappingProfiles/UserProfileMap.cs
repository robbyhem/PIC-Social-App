using AutoMapper;
using PIC_SocialApp.Application.UserProfiles.Commands;
using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC_SocialApp.Application.MappingProfiles
{
    internal class UserProfileMap : Profile
    {
        public UserProfileMap() 
        { 
            CreateMap<CreateUserCommand, BasicInfo>().ReverseMap(); 
        }
    }
}
