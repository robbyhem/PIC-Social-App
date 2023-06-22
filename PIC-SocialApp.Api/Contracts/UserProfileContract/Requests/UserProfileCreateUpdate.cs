﻿using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;

namespace PIC_SocialApp.Api.Contracts.UserProfileContract.Requests
{
    public record UserProfileCreateUpdate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CurrenCity { get; set; }
    }
}
