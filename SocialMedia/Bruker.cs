using System;
using System.Collections.Generic;


namespace FriendFace
{
    internal class Bruker
    {
        //Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public List<Bruker> Friends { get; } = new List<Bruker>();

        //Constructor
        public Bruker(string name, string email, int age, string sex)
        {
            Name = name;
            Email = email;
            Age = age;
            Sex = sex;
        }

        //Metoder
        public void ShowProfile()
        {
            Console.WriteLine($"Hei, { Name }!");
            Console.WriteLine($"Email: { Email }");
            Console.WriteLine($"Age: { Age }");
            Console.WriteLine($"Sex: { Sex }");
        }

        public void ShowFriends()
        {
            Console.WriteLine("Dine venner: ");
            foreach (Bruker friend in Friends)
            {
                Console.WriteLine(friend.Name);
            }
        }

        public void ViewFriend(Bruker friend)
        {
            Console.WriteLine($"Din venn { friend.Name }!");
            Console.WriteLine($"Email: { friend.Email }");
            Console.WriteLine($"Age: { friend.Age }");
            Console.WriteLine($"Sex: { friend.Sex }");
        }

        public void AddFriend(Bruker friend)
        {
            Friends.Add(friend);
            Console.WriteLine($"La til { friend.Name } som venn.");
        }

        public void RemoveFriend(Bruker friend)
        {

            for (int i = 0; i < Friends.Count; i++)
            {
                if (friend.Name == Friends[i].Name)
                {
                    Friends.RemoveAt(i);
                    Console.WriteLine($"Fjernet { friend.Name } som venn.");

                }
            }

        }
    }
}
