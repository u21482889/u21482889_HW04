using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21482889_HW04.Models
{
    public class Pollution : Tree
    {   
        


        public Pollution( int speciesCount, int quantity):base(quantity)
        {   
            
            SpeciesCount = speciesCount;
            if (speciesCount<quantity/3)
            { ratioStatus = "You have too little Pollution type trees, plant more!"; }
            if(speciesCount>quantity/3)
            { ratioStatus = "You have a bit too many Pollution type trees, try to plant less in future or plant more of the other types to achieve balance."; }
            if(speciesCount==quantity/3)
            { ratioStatus = "Congrats! the amount of Pollution trees you have currently is perfectly balanced!"; }

            

        }

        public override string RatioStatus()
        {
            return ratioStatus;
        }

        public override string EcoSuggestions()
        {   if (TreeCount >= 60)
            { return "You have enough trees but take note of you ratio status.";}
            else
            { return "You do not have enough trees in total. Pollution trees are very important for purifying the air around us so get more!"; }
        }


    }






}