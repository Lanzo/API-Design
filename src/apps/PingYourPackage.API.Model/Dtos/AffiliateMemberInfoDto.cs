using System;

namespace PingYourPackage.API.Model.Dtos {
    
    public class AffiliateMemberInfoDto {

        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsLocked { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
    }
}
