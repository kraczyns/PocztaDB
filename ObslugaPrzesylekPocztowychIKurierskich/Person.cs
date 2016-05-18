using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObslugaPrzesylekPocztowychIKurierskich
{
   public class Person
    {
        private string name { get; set; }
        private string surname { get; set; }
        private string address { get; set; }

        public Person(string _name, string _surname, string _address = null)
        {
            this.name = _name;
            this.surname = _surname;
            this.address = _address;
        }
    }
}
