using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
   public class AddJobViewModel
   {
      [Required]
      public string? Name { get; set; }
      public int EmployerId { get; set; }
      public List<SelectListItem>? Employers { get; set; }

      // public AddJobViewModel(List<Employer> employers)
      // {

      // }
   }

}

