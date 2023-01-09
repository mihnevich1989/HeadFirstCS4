using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clown
{
    class Clown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
        /// <summary>
        /// 
        /// </summary>
        public static void StaticTalkAboutYourself()
        {
            Console.WriteLine($"My name is Static and I'm 1 inches tall.");
        }
    }
}
