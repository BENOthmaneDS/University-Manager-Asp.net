using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationAuth.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Required(ErrorMessageResourceName = "userErr", ErrorMessageResourceType = typeof(Resources.ModelsResources.ResourceAccount))]
        [Display(Name = "userName", ResourceType = typeof(Resources.ModelsResources.ResourceAccount))]
        public string UserName { get; set; }
        [Required(ErrorMessageResourceName = "pwdErr", ErrorMessageResourceType = typeof(Resources.ModelsResources.ResourceAccount))]
        [Display(Name = "pwd", ResourceType = typeof(Resources.ModelsResources.ResourceAccount))]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}