namespace MyLibrary
{
    public partial class Person
    {
        public Person this[int index]
        {
            get { return Children[index]; }
            set { Children[index] = value; }
        }

        private string _favoritePrimaryColor;
        public string FavoriteIceCream { get; set; }

        public string FavoritePrimaryColor
        {
            get => _favoritePrimaryColor;
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "yellow":
                    case "blue":
                        _favoritePrimaryColor = value;
                        break;
                    default:
                        throw new ArgumentException(
                        $"{value} is not a primary color!"
                        );
                }

            }
        }


        // property C# 1-5 style
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // property C# 6+ lambda expression body syntax
        public string Greetings => $"{Name} says Hello!";
        public int Age => DateTime.Today.Year - DateofBirth.Year;
    }
}
