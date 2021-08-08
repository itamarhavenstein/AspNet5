using Newtonsoft.Json;  
using System;  
using System.Collections.Generic;  
using System.ComponentModel.DataAnnotations;  
using System.Text;  

namespace Services.ViewModels
{
    public class LoginModel
    {
      [JsonProperty(PropertyName = "username")]
      [Required]
      public string UserName { get; set; }
      [JsonProperty(PropertyName = "password")]
      [Required]
      public string Password { get; set; }
    }
}