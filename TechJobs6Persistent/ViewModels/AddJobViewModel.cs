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
      public List<SelectListItem>? Employers { get; set; } = new List<SelectListItem>();

      public AddJobViewModel() { }
      public AddJobViewModel(List<Employer> employers)
      {
         foreach (var employer in employers)
         {
            SelectListItem item = new SelectListItem(employer.Name, employer.Id.ToString());
            Employers.Add(item);
         }
      }
   }

}

