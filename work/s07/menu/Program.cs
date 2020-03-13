/**
 *  Example from 
 * https://wellsb.com/csharp/beginners/create-menu-csharp-console-application/
 */﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace menu
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) View accounts");
            Console.WriteLine("2) View account by ID");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
         
            switch (Console.ReadLine())
            {
                case "1":
                    PrintAccounts();
                    return true;
                case "2":
                    Console.WriteLine("Please input nr");
                    var nr = Convert.ToInt32(Console.ReadLine());
                    PrintSpecificAccount(nr);
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void PrintAccounts()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("ID-BALANCE-LABEL-OWNER");
            foreach (var account in ViewAccounts())
            {
                Console.WriteLine(account.Number + " - " + account.Balance + " - " + account.Label + " - " + account.Owner);
            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        private static IEnumerable<Account> ViewAccounts()
        {
            const string file = "../../../../data/account.json";
            using var r = new StreamReader(file);
            var data = r.ReadToEnd();
            var json = JsonSerializer.Deserialize<Account[]>(data,
                new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            return json;
        }

        private static void PrintSpecificAccount(int nr)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("ID-BALANCE-LABEL-OWNER");
            foreach (var account in ViewAccounts())
            {
                if (account.Number != nr) continue;
                Console.WriteLine(account.Number + " - " + account.Balance + " - " + account.Label + " - " + account.Owner);
                Console.WriteLine("--------------------------------------------------------------");
                return;
            }
            Console.WriteLine("NO ACCOUNT FOUND");
            Console.WriteLine("--------------------------------------------------------------");
        }
    }

    public class Account
    {
        public int Number { get; set; }
        public int Balance { get; set; }
        public string Label { get; set; }
        public int Owner { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
