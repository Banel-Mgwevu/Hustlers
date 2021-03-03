using Hustlers.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hustlers.Domain.Models.RecruiterViewModel
{
    public class EditRecruiterViewModel : BaseRecruiterViewModel
    {
        public string RecruiterId { set; get; }
    }
}
