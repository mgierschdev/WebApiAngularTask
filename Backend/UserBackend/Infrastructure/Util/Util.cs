namespace Infrastructure.Helper;
using System;
using System.Net.NetworkInformation;
using Infrastructure.Model;

public class Util
{
    private Random Random;

    public Util()
    {
        Random = new Random();
    }

    public List<User> GetMockUserList()
    {
        List<User> list = new List<User>();

        // generates 20 random mock users
        for (int i = 0; i <= 20; i++)
        {
            List<Post> posts = new List<Post>();
            int numberPosts = Random.Next(1, 10);
            for (int j = 0; j <= numberPosts; j++)
            {
                Post currentPost = new Post("Title - " + Random.Next(0, 10)+ "-" + Random.Next(0, 1000), "Content - " + Random.Next(0, 100) + "-" + Random.Next(0, 100), DateTime.Now);
                posts.Add(currentPost);

            }
            string name = GetRandomName();
            string email = GetRandomEmail(name);
            User current = new User(name, GetRandomLastName(), email, GetRandomPhoneAustrianNumber(), Random.Next(0, 1500), DateTime.Now, DateTime.Now, posts);
            list.Add(current);
        }
        return list;
    }

    private string GetRandomEmail(string name)
    {
        List<string> emailProviders = new List<string>
        {
            "@google.com",
            "@yahho.com",
            "@hotmail.com",
            "@outlook.com",
            "@icloud.com"
        };

        return name + Random.Next(0, 100) + emailProviders[Random.Next(0, emailProviders.Count)];
    }

    private string GetRandomName()
    {
        // source: top most common names in austria https://en.wikipedia.org/wiki/List_of_most_popular_given_names
        List<string> names = new List<string>{
            "Marie",
            "Emilia",
            "Anna",
            "Emma",
            "Lena",
            "Mia",
            "Laura",
            "Anna",
            "Hannah",
            "Lea",
            "Paul",
            "Jakob",
            "Noah",
            "Elias",
            "David",
            "Felix",
            "Leon",
            "Thomas",
            "Tobias",
            "Theo",
            "Emil",
            "Ben"
        };

        return names[Random.Next(0, names.Count)];
    }

    private string GetRandomLastName()
    {
        // source: List of most common surnames in Europe https://en.wikipedia.org/wiki/List_of_most_common_surnames_in_Europe
        List<string> lastname = new List<string>{
            "Gruber",
            "Huber",
            "Bauer",
            "Wagner",
            "Müller",
            "Pichler",
            "Karl",
            "Steiner",
            "Moser",
            "Mayer",
            "Hofer",
            "Leitner",
            "Berger",
            "Fuchs",
            "Eder",
            "Fischer",
            "Schmid",
            "Weber",
            "Schwarz",
            "Schneider",
            "Reiter",
            "Mayr"
        };

        return lastname[Random.Next(0, lastname.Count)];
    }

    // returns a 8 digit number
    public string GetRandomPhoneAustrianNumber()
    {
        string number = "";
        for (int i = 0; i < 8; i++)
        {
            number += "" + Random.Next(0, 9);
        }
        return "+43" + number;
    }
}