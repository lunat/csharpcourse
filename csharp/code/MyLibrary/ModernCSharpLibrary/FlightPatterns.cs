namespace ModernCSharpLibrary
{
    public class BusinessClassPassenger
    {
        public override string ToString()
        {
            return "Business Class";
        }
    }

    public class FirstClassPassenger
    {
        public int AirMiles { get; set; }
        public override string ToString()
        {
            return $"First Class with {AirMiles:N0} air miles";
        }
    }

    public class CoachClassPassenger
    {
        public double CarryOnKg { get; set; }
        public override string ToString()
        {
            return $"Coach Class with {CarryOnKg:N2} KG to carry on";
        }
    }
}