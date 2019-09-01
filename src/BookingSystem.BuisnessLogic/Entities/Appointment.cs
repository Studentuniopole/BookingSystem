using System;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class Appointment : BaseEntity
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public Customer Customer { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public Employee Employee { get; set; }



        public string Description { get; set; }
        public bool IsFullDay { get; set; }

        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        // public virtual AppointmentType AppointmentType {get; set;}
        
    }
}