using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }

        public List<SelectListItem> SelectEmployer {get; set; }
        public List<Skill> Skills { get; set; }

        public AddJobViewModel(List<Employer> possibleEmployer, List<Skill> skills)
        {
            SelectEmployer = new List<SelectListItem>();

            foreach (var employer in possibleEmployer)
            {
                SelectEmployer.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
                Skills = skills;
            }
        }
        public AddJobViewModel()
        {
        }
    }
}
