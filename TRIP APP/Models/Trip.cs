using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripConsole;

namespace TRIP_APP.Models
{
    internal class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Trip> lsTrip { get; set; }
        public static List<Person> lsPerson { get; set; } = new List<Person>();



        public static void AddPerson(Person person)
            => lsPerson.Add(person);

        public static List<Person> DisplayPeople()
        {
            return lsPerson;
        }
    }
}
