using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkCLI
{
    internal class Nationality
    {
        int NationalityId;// NationalityID
        string NationalityName;// NationalityName

        public int NationalityId1 { get => NationalityId; set => NationalityId = value; }
        public string NationalityName1 { get => NationalityName; set => NationalityName = value; }

        // Methods
        public Nationality(int id, string name) // Nationality
        {
            NationalityId = id;
            NationalityName = name;
        }

        // ToString
    }
}
