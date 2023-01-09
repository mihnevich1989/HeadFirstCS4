using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HasASecret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HasASecret keeper = new HasASecret();

            FieldInfo[] field = keeper.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo fieldInfo in field)
            {
                Console.WriteLine(fieldInfo.GetValue(keeper));
            }

        }
    }
}
