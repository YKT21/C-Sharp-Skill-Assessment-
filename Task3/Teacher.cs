using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Teacher : Person
    {
        private string _faculty;

        //TODO: 4, add constructor
        public Teacher(string name, string faculty) : base(name)
        {
            this._faculty = faculty;
        }

        public override void PrintDetails()
        {
            //TODO: 5, print details to console
            Console.WriteLine($"Hi my name is {base._name} and I teach {this._faculty} faculty");
        }
    }
}
