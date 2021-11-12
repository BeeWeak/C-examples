using System;

namespace OOYA_dating
{
    class Profile
    {
        //Fields

        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        //Constructors

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.age = age;
            this.name = name;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
        }

        //Properties


        //Methods
        public string ViewProfile()
        {
            string information = $" Name: {name},\n Age: {age},\n City: {city},\n Country: {country},\n Pronouns: {pronouns},\n";
            Console.WriteLine(information);
            return information;

        }


        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}

