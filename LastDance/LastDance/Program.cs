using System;
using System.Collections.Generic;

namespace LastDance
{
    class Program
    {
        static void Main(string[] args)

        {

            List<Student> students = new List<Student>(){
            new Student(22,"Vanja","Atanasoski","vanja","vanja",Role.Student,new List<string>{"Bio","geo","math" }),
            new Student(23,"Dragan","Draganovski","drg","drg",Role.Student,new List<string>{"Bio","geo","math" }),
            new Student(22,"Bane","Bane","br","br",Role.Student,new List<string>{"Bio","geo","math" }),
            new Student(22,"Darko","Darko","dr","dr",Role.Student,new List<string>{"Bio","geo","math" }),
            };



            List<User> users = new List<User>() {
            new Student(22,"Vanja","Atanasoski","vanja","vanja",Role.Student,new List<string>{"Bio","geo","math" }),
            new Student(23,"Dragan","Draganovski","drg","drg",Role.Student,new List<string>{"Bio","geo","math" }),
            new Student(22,"Bane","Bane","br","br",Role.Student,new List<string>{"Bio","geo","math" }),
            new Student(22,"Darko","Darko","dr","dr",Role.Student,new List<string>{"Bio","geo","math" }),
            new Trainer(22,"Miki","Miki","Miki","Miki",Role.Trainer,students),
            new Trainer(25,"Ivan","Ivan","iv","iv",Role.Trainer,students),
            new Trainer(22,"Dzani","Dz","dz","dz",Role.Trainer,students),
            new Trainer(22,"Brani","br","br","br",Role.Trainer,students),
            new Admin(22, "Blaze", "Miki", "Miki", "Miki", Role.Admin),
            new Admin(25, "Faze", "Ivan", "iv", "iv", Role.Admin),
            new Admin(22, "Heroic", "Dz", "dz", "dz", Role.Admin),
            new Admin(22, "stavn", "st", "st", "st", Role.Admin),
            };

            Console.WriteLine("Vnesete Username");
            string username =Console.ReadLine();
            Console.WriteLine("Vnesete Password");
            string password = Console.ReadLine();
            User currentUser=null;
            

            for(int i = 0; i<users.Count; i++){
                if(users[i].Username==username && users[i].Password == password)
                {
                    if (users is Admin)
                    {
                        Console.WriteLine("Vie ste admin ");
                        
                        Admin admin = (Admin)users[i];

                        break;
                    }
                    else if(users is Trainer)
                    {
                        Trainer trainer = (Trainer)users[i];
                        Console.WriteLine("Vie ste Trener");
                        break;
                    }
                    else if(users is Student)
                    {
                        Student student = (Student).users[i];
                        Console.WriteLine("Vie ste Student");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Bye:)");
                    }
                }
            }




        }
       
    }
}
