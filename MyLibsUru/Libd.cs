using AeroportShatohin.Classes;

namespace MyLibsUru
{
    public class Libd<AddAll> where AddAll : class
    {
        public List<AddAll> flights = new List<AddAll>();
        public List<AddAll> GetList()
        {
            return flights;
        }
        public AddAll Add(AddAll flight)
        {
            flights.Add(flight);
            return flight;
        }
        public void Change(AddAll oldget, AddAll newget)
        {
            flights[flights.IndexOf(oldget)] = newget;
        }
        public void Remove(AddAll flight)
        {
            flights.Remove(flight);
        }
    }
}