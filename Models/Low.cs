using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21482889_HW04.Models
{
    public class Low : Tree
        {
        public Low(int speciesCount, int quantity) : base(quantity)
        {
            SpeciesCount = speciesCount;
            if (speciesCount < quantity / 3)
            { ratioStatus = "You have too little low maintenance trees, plant more!"; }
            if (speciesCount > quantity / 3)
            { ratioStatus = "You have a bit too many low maintenance trees, try to plant less in future or plant more of the other types to achieve balance."; }
            if (speciesCount == quantity / 3)
            { ratioStatus = "Congrats! the amount of low maintenance trees you have currently is perfectly balanced!"; }

        }

        public override string RatioStatus()
        {
            return ratioStatus;
        }

        public override string EcoSuggestions()
        {
            if (TreeCount >= 60)
            { return "You have enough trees but take note of you ratio status."; }
            else
            { return "You do not have enough Low maintenance trees in total. These type of trees may be expensive at first but they are very low maintenance which means they will save the zoo money in the long run so try and plant more of them."; }
        }

    }

 
}