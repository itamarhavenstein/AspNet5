using Newtonsoft.Json;  
using System;  
using System.Collections.Generic;  
using System.ComponentModel.DataAnnotations;  
using System.Text;  

namespace Services.ViewModels
{
    public class RolesModel
    {
      [JsonProperty(PropertyName = "role_id")]
      public int RoleId { get; set; }
      [JsonProperty(PropertyName = "role_name")]
      public string RoleName { get; set; }
    }
   
}