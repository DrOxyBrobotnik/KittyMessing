using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kittymessing
{
    public class testclass
    {
        private string _name;
        public string Name 
        {
            get { return _name; }
            set 
            {
                if(value == null) 
                {
                    throw new ArgumentNullException("You tried to assign null"); 

                    _name = value;
                }
            }
        }
        
    }
}

