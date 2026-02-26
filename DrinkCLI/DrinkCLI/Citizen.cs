using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DrinkCLI
{
    internal class Citizen
    {
        int Age; // Age
        int CitizenID; // CitizenI
        string Drinking; // Drinking
        string DrinkingWeekdays; // DrinkingWeekdays
        string DrinkingWeekends; // DrinkingWeekends
        string Gender; // Gender
        // Nationality
        string NetIncome; // NetIncome
        // PopulationGroup
        string SchoolDropout; // SchoolDropOut
        string State; // State
        string Treatment; // Treatment

        public int Age1 { get => Age; set => Age = value; }
        public int CitizenID1 { get => CitizenID; set => CitizenID = value; }
        public string Drinking1 { get => Drinking; set => Drinking = value; }
        public string DrinkingWeekdays1 { get => DrinkingWeekdays; set => DrinkingWeekdays = value; }
        public string DrinkingWeekends1 { get => DrinkingWeekends; set => DrinkingWeekends = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public Nationality Nation { get; set; }
        public string NetIncome1 { get => NetIncome; set => NetIncome = value; }
        public PopulationGroup Group { get; set; } 
        public string SchoolDropout1 { get => SchoolDropout; set => SchoolDropout = value; }
        public string State1 { get => State; set => State = value; }
        public string Treatment1 { get => Treatment; set => Treatment = value; }

        // Methods
        public Citizen(string dataset)
        {
            string[] data = dataset.Split(';');
            // Citizen Id:
            Age = Convert.ToInt32(data[0]);
            Drinking = data[1];
            DrinkingWeekdays = data[2];
            DrinkingWeekends = data[3];
            Gender = data[4];
            Nation = new Nationality(Convert.ToInt32(data[5]), data[6]); // Nationality:
            NetIncome = data[7];
            Group = new PopulationGroup(Convert.ToInt32(data[8]), data[9]); // PopulationGroup;
            SchoolDropout = data[10];
            State = data[11];
            Treatment = data[12];
        }
        public string Average() // Average
        {
            if (Drinking == "No")
            {
                return "Not drinkinng";
            }
            else
            {
                int Weekdays = Convert.ToInt32(DrinkingWeekdays);
                int Weekends = Convert.ToInt32(DrinkingWeekends);
                return Convert.ToString((Weekdays + Weekends) / 2);
            }
        }
        public void citizens() // Citizen
        {
            Console.WriteLine($"Citizen Id: {CitizenID}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Drinking: {Drinking}");
            Console.WriteLine($"Drinking on weekdays: {DrinkingWeekdays}");
            Console.WriteLine($"Drinking on weekends: {DrinkingWeekends}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Nationality: {Nation.NationalityName1}");
            Console.WriteLine($"Net income: {NetIncome}");
            Console.WriteLine($"Population Group: {Group.PopulationGroupName1}");
            Console.WriteLine($"Drop out from school: {SchoolDropout}");
            Console.WriteLine($"State: {State}");
            Console.WriteLine($"Treatment: {Treatment}");
            Console.WriteLine($"Average drinking: {Average()}");
            Console.WriteLine(""); // Sortores
        }

        // ToString
    }
}
