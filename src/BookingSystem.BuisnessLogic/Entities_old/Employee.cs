using System.Collections.Generic;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class Employee: BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}