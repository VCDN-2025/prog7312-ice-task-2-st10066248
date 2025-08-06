namespace TravelItineraryPlanner
{
    public class Destination
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }

        public Destination(string name, string country, string description)
        {
            Name = name;
            Country = country;
            Description = description;
        }

        public override string ToString() =>
            $"{Name}, {Country}: {Description}";

        public override bool Equals(object obj) =>
            obj is Destination d &&
            Name == d.Name &&
            Country == d.Country &&
            Description == d.Description;

        public override int GetHashCode() =>
            (Name, Country, Description).GetHashCode();
    }
}
