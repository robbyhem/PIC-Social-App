using AutoMapper;
using PIC_SocialApp.Api.Contracts.UserProfileContract.Requests;
using PIC_SocialApp.Api.Contracts.UserProfileContract.Responses;
using PIC_SocialApp.Application.UserProfiles.Commands;
using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;

namespace PIC_SocialApp.Api.MappingProfiles
{
    public class UserProfileMappings : Profile
    {
        public UserProfileMappings()
        {
            CreateMap<UserProfileCreateUpdate, CreateUserCommand>();
            CreateMap<UserProfileCreateUpdate, UpdateUserProfileBasicInfo>();
            CreateMap<UserProfile, UserProfileResponse>();
            CreateMap<BasicInfo, BasicInfoResponse>();
        }
    }
}
