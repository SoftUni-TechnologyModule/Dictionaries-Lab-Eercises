namespace _01Е.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Phonebook
    {
        static void Main()
        {
            
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] != "END")
                {
                    if (command[0] == "A")
                    {
                        phoneBook = FillDictionary(phoneBook, command);
                    }
                    else
                    {
                        CheckingForExistingContact(phoneBook, command);
                    }
                    
                }
                else
                {
                    return;
                }
            }
        }

        static void CheckingForExistingContact(Dictionary<string, string> phoneBook, string[] command)
        {
            if (phoneBook.ContainsKey(command[1]))
            {                                            
                Console.WriteLine($"{command[1]} -> {phoneBook[command[1]]}");
            }
            else
            {
                Console.WriteLine($"Contact {command[1]} does not exist.");
            }
        }

        static Dictionary<string, string> FillDictionary(Dictionary<string, string> phoneBook, string[] command)
        {
            phoneBook[command[1]] = command[2];

            return phoneBook;
        }
    }
}
