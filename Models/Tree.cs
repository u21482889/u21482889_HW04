using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21482889_HW04.Models
{
    public abstract class Tree
    {
        public int TreeCount;
        protected string ratioStatus;
        protected int SpeciesCount;
        protected string _EcoStatus;
        
       public Tree(int quality)
        {
            TreeCount = quality;
        
        }


        public abstract string RatioStatus();
        public virtual string EcoSuggestions()
        {
            if (TreeCount >= 60)
            {
                return "Well Done! You have enough trees to help sustain a healthy ecosystem. Please go to the other pages for more suggestions and details on each type of tree.";
                
            }
            else
            {
                return "OH NO! You have less that the minumum required trees to sustain a healthy ecoosystem, please plant more trees. Go to the other pages for suggestions and details on each type of tree.";
                
            }
        }

       
    }
}