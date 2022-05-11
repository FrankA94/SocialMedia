using System;

namespace FriendFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bruker Ben = new Bruker("Ben David", "asd@asd.com", 22, "Male");
            Bruker Frank = new Bruker("Frank", "frank@asd.com", 27, "Male");
            Bruker Thomas = new Bruker("Thomas", "Thomas@asd.com", 30, "Male");
            Bruker Terje = new Bruker("Terje", "Terje@asd.com", 47, "Male");
            Bruker Therese = new Bruker("Therese", "asd@asd.com", 28, "Female");

            Bruker[] AllUsers = new Bruker[] { Ben, Frank, Thomas, Terje, Therese };

            Bruker LoggedinnUser = Frank;

            LoggedinnUser.ShowProfile();


            while (true)
            {
                string kommando = Console.ReadLine().ToLower();
                string[] splitKommando = kommando.Split(" ");
                Console.Clear();
                LoggedinnUser.ShowProfile();


                switch (splitKommando[0])
                {
                    case "add":
                        LoggedinnUser.AddFriend(GetUserFromName(splitKommando[1], AllUsers));
                        break;
                    case "remove":
                        LoggedinnUser.RemoveFriend(GetUserFromName(splitKommando[1], AllUsers));
                        break;
                    case "friends":
                        LoggedinnUser.ShowFriends();
                        break;
                    case "view":
                        LoggedinnUser.ViewFriend(GetUserFromName(splitKommando[1], AllUsers));
                        break;
                    default:
                        Console.WriteLine("Kommando er ikke tilgjenglig.");
                        break;
                }
            }


            static Bruker GetUserFromName(string name, Bruker[] users)
            {
                foreach (Bruker bruker in users)
                {
                    if (bruker.Name.ToLower().Contains(name))
                    {
                        return bruker;
                    }
                }

                return null;
            }
        }
    }
}
