using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class Salon : BaseEntity
    {
        /// <summary>
        /// Nazwa zwyczajowa salonu
        /// np idealnie
        /// </summary>
        [Required(ErrorMessage = "Pole nazwa jest wymagane")]
        public string Name { get; set; }

        /// <summary>
        /// Formalna nazwa salonu
        /// np idealnie sp zoo
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Ulica
        /// </summary>
        [Required(ErrorMessage = "Pole ulica jest wymagane")]
        public string AddressStreet { get; set; }

        /// <summary>
        /// Numer budynku
        /// </summary>
        [Required(ErrorMessage = "Pole numer budynku jest wymagane")]
        public int AddressBuildingNumber { get; set; }

        /// <summary>
        /// Numer mieszkania
        /// </summary>
        public int AddressApartmentNumber { get; set; }

        /// <summary>
        /// Numer mieszkania
        /// </summary>
        [Required(ErrorMessage = "Pole numer telefonu jest wymagane")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Godziny otwarcia salonu Dzień tygodnia, od, do 
        /// </summary>
        public virtual ICollection<WorkingHour> WorkingHours { get; set; }


        /// <summary>
        /// Lista pracowników
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; }








        
    }
}