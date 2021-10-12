using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorToDoApp.Data.Models
{
    public class TaskModel
    {
        [Required(ErrorMessage = "Task Empty")]
        [StringLength(50, ErrorMessage ="Too long")]
        [MinLength(5, ErrorMessage ="Too short")]
        public string TaskName { get; set; }
        public bool IsComplete { get; set; }
    }
}
