using System;

namespace PredicateTest
{
    class Program
    {

        private bool running = true;
        static void Main(string[] args)
        {
            new Program().Run();   
        }

        private void Run()
        {

            while (running) { 
                PrintMenu();
                SelectOpt(Console.ReadLine());
                Console.ReadKey();
            }

        }

        private void PrintMenu()
        {
            Console.WriteLine("1. Print everyone");
            Console.WriteLine("2. Print brown-haired people");
            Console.WriteLine("3. Sort list by name");
            Console.WriteLine("4. Sort list by hair color");
            Console.WriteLine("5. Sort list by age");

        }

        private void SelectOpt(string opt)
        {
            switch (opt)
            {
                case "1":
                    PrintEveryone();
                    break;
                case "2":
                    PrintBrownHairedPeople();
                    break;
                case "3":
                    PersonRepository.Instance.SortListByName();
                    break;
                case "4":
                    PersonRepository.Instance.SortListByHairColor();
                    break;
                case "5":
                    PersonRepository.Instance.SortListByAge();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }

        private void PrintEveryone()
        {
            foreach (IPerson p in PersonRepository.Instance.GetEveryone())
            {
                Console.WriteLine(p);
            }
        }

        private void PrintBrownHairedPeople() { 
        foreach(IPerson p in PersonRepository.Instance.GetBrownHaired())
            {
                Console.WriteLine(p);
            }
        }
    }
}
