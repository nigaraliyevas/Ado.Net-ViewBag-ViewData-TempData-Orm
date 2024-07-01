
namespace AdoNetPractice.Models
{
    public class County
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Population { get; set; }
        public List<City> Cities { get; set; }
        public override string ToString()
        {
            return ("Id:" + Id + "" + "Name:" + Name + "" + "Population:" + Population);
        }
    }

}

