using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        public int Username { get; set; }

    private int myVar;
        public int MyProperty { 
            get{return myVar; }
            set{myVar=value; } 
        }
    }


}