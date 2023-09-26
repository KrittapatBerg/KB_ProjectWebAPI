using KB_WebAPI.databaseContext;

namespace KB_WebAPI.Models
{
    public class SeedGenerator : Random
    {
        
        #region Address generator
        string[] _streetName = "Flower Rd, Moon street, Ion Rd, Riverflow, st.Septon, Sun n Star street, Dark horse Rd".Split(", ");

        string[] _country = "High Tower, Middle Korea, King's Landing, Casterly Rock, South Sea, Winterfell, Central Highgarden, Black Sea, South Dothraki, North Sea, Central Sea".Split(", ");

        string[] _city = "New Sea, Black Sea, Dark Sea, Bright Sea, Star Sea, Old Sea, Blue Sea, North Sea, Iron Sea".Split(", ");

        public int Zipcode => this.Next(10110, 50550);
        public string Country => _country[Next(0, _country.Length)];
        public string StreetName => _streetName[Next(0, _streetName.Length)];
        public string City => _city[Next(0, _city.Length)];
        #endregion

        #region Attraction generator 

        string[] _attractionName = "Sunshine Bay, Raiya Beach, Lego Land, Aquarium, Sea World, Niagara Fall, Redwood, Fancy Raw".Split(", ");
        
        string[] _category = "Park, Restaurant, Café, Museum, Architecture, Waterfall, Beach, Forest, Hotel".Split(", ");

        string[] _description =
        {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
            "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
            "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat " +
            "nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui " +
            "officia deserunt mollit anim id est laborum."
        };


        public string Attraction => _attractionName[Next(0, _attractionName.Length)];
        public string Category => _category[Next(0, _category.Length)];
        public string Description => _description[Next(0, _description.Length)];
        #endregion

        #region User generator 
        string[] _username = "Kitty, Jon, Jeff, Joff, Tuna, Jim, Pam, Paul, Roger, Steve, Louis, Bryan, David, Rebecca, Clerance".Split(", ");

        string[] _mail = "icloud.com, me.com, buzz.com, lightning.com, speedy.com".Split(", ");
        #endregion


        public static void SeedData(DataContext context)
        {
            if (!context.Addresses.Any()) 
            {
                var address1 = new csAddress
                {
                    StreetName = "Flower Rd",
                    City = "Blue Sea",
                    Country = "Central Highgarden",
                    Zipcode = 20162
                };
                context.Addresses.Add(address1);

                var address2 = new csAddress
                {
                    StreetName = "st.Septon",
                    City = "South Sea",
                    Country = "Central Highgarden",
                    Zipcode = 20163
                };
                context.Addresses.Add(address2);

                //context.SaveChanges(); 
            }
        }
        /*
        #region Address class
        string[][] _streetName =
        {
            "Kings Rd, Queens Rd, Prince Rd, Princess Rd, Joker Rd, Human Rd, Klingon Rd, Vulcan Rd, Tallax Rd".Split(", "),
            "Diamond street, Ruby street, Steel street, Iron street, Gold street, Platinum street, Jade street".Split(", "),
            "Amber Rd, Tree Farm, Animal Farm, Bug Farm, Bee Rd, Stone street, stick street, River Rd, Garden street".Split(", ")
        };

        string[][] _city =
        {
            "New Town, New Jersey, New Chester, New Jerusalem, New Cannes, New Sanfran, New Riverrun, New Winterfell, New Twins, New Wall".Split(", "),
            "Old Town, Old York, Old Land, Old Tower, Old Budapest, Old Lancaster, Old Georgia, Old Castle, Old Winterfell, Old Riverrun".Split(", "),
            "Little Town, Little Soeul, Little Jeju, Little Hawaii, Little Panama, Little Amazon, Little Sicily, Little Laos, Little Tigergrass, Little Dragon".Split(", "),
            "Big Town, Big Okinawa, Big Soeul, Big Cannes, Big LA, Big Malay, Big Toscani, Big Tajraj, Big Pompeii, Big Winterfell".Split(", "),
            "Tiny Town, Tiny Jersey, Tiny Chester, Tiny Jerusalem, Tiny Cannes, Tiny Sanfran, Tiny Riverrun, Tiny Winterfell, Tiny Twins, Tiny Wall".Split(", "),
            "Tiny Soeul, Tiny Jeju, Tiny Hawaii, Tiny Panama, Tiny Amazon, Tiny Sicily, Tiny Laos, Tiny Tigergrass, Tiny Dragon, Tiny Phuket".Split(", "),
            "Mini Town, Mini Jersey, Mini Chester, Mini Jerusalem, Mini Cannes, Mini Sanfran, Mini Riverrun, Mini Winterfell, Mini Twins, Mini Wall".Split(", ")
        };

        string[] _country = "High Tower, Middle Korea, King's Landing, Casterly Rock, South Sea, Winterfell, Central High Garden, Black Sea, South Dothraki, North Sea, Central Sea".Split(", ");

        int _zipcode => this.Next(10110, 50550);
         
        public string streetName => _streetName[Next(0, _streetName.Length)];
        #endregion

        #region User class
        string[][] _username =
        {
            "Kim, Kerry, Kyle, Kai, Ken, Aaron, Ari, Ariel, Aurora, Barbie".Split(", "),
            "Beth, Britney, Bay, Bruno, Bronx, Brooklyn, Cedar, Caroline, Crescen, Cruella".Split(", "),
            "Timone, Tom, Twain, Tully, Tarly, Truce, Ellen, Eli, Ethan, Eugene".Split(", "),
            "Freddy, Francis, Frankie, Frued, Flower, Gemie, Gem, George, Hailey, Howl".Split(", "),
            "Ponyo, Totoro, Joffrey, Marie, Sally, Harry, Jon, Robb, Caterlyn, Arya, Sansa, Eddard".Split(", "),
        };

        string[] _mail = "icloud.com, me.com, buzz.com, lightning.com, speedy.com".Split(", ");
        #endregion

        #region Attraction class
        string[][] _attraction =
        {
            "National, Park, Falls, Beach, Lay, Bay, Tower, Castle, Town, View".Split(", "),
            "Land, Lego, Flag, Natural, Safarie, Sugar  ".Split(", ")
        }; 
        #endregion
        */

    }
}
