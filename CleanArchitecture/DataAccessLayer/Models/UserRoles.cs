using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class UserRoles : BaseModel
    {
        [JsonProperty(PropertyName = "role_id")]
        public int RoleId { get; set; }
        [JsonProperty(PropertyName = "role_name")]
        public string RoleName { get; set; }
        public virtual User User { get; set; }
    }
}