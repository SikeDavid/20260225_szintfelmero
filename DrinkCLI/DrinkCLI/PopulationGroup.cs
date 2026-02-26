using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkCLI
{
    internal class PopulationGroup
    {
        int PopulationGroupId; // PopuationGroupId
        string PopulationGroupName; // PopulationGroupName

        public int PopulationGroupId1 { get => PopulationGroupId; set => PopulationGroupId = value; }
        public string PopulationGroupName1 { get => PopulationGroupName; set => PopulationGroupName = value; }

        // Methods
        public PopulationGroup(int id, string name) // PopulationGroup
        {
            PopulationGroupId = id;
            PopulationGroupName = name;
        }

        // ToString
    }
}
