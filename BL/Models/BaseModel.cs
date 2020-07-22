using System;
using System.ComponentModel.DataAnnotations;

namespace BL.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public ValidationResult ValidationResult{ get; set; }
    }
}
