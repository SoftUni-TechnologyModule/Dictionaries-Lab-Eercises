namespace _02E.Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;

    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] != "END")
                {
                    if (command[0] == "A")
                    {
                        phoneBook = FillDictionary(phoneBook, command);
                    }
                    else if (command[0] == "S")
                    {
                        CheckingForExistingContact(phoneBook, command);
                    }
                    else
                    {
                        PrintPhoneBook(phoneBook);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        static void PrintPhoneBook(SortedDictionary<string, string> phoneBook)
        {
            foreach (KeyValuePair<string, string> pair in phoneBook)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }

        static void CheckingForExistingContact(SortedDictionary<string, string> phoneBook, string[] command)
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

        static SortedDictionary<string, string> FillDictionary(SortedDictionary<string, string> phoneBook, string[] command)
        {
            phoneBook[command[1]] = command[2];

            return phoneBook;
        }
    }
}

