using System;
using System.ComponentModel.DataAnnotations;

namespace time_management_matrix.Models
{
    public class TaskForm
    {
        [Key]
        [Required]
        public int TaskID { get; set; }

        [Required(ErrorMessage = "Task is Required")]
        public string Task { get; set; }

        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Quadrant is Required")]
        public int Quadrant { get; set; }

        public bool Completed { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
