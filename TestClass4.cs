using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kittymessing
{
    internal class TestClass4
    {
        public string mood;

        public string HasHonors()
        {
            if (mood == "Meh")
            {
                return "alright then";
            }
            else
            {
                return "Oh well";
            }
            
        }

        public TestClass4(string aMood)
        {
            mood = aMood;
            HasHonors();
        }
    }
}





