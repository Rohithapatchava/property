using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class Program
    {
        static void main(String[] args)
        {
           demo dem = new demo();
           dem.Age = 22;
            Console.WriteLine(dem.Age);
        }
    }

}
    class demo
    {
        int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        
}
