using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Setu Kumar";
            owner.LastName = "Basak";
            owner.EmailAddress = "setu677@gmail.com";
            owner.PhoneNumber = "888888";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformWorked(5);
            chore.PerformWorked(3);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
