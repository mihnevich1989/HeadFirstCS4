using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// Выдает часть своих денег, удаляя их из кармана (или вывдит на консоль
        /// сообщение о том, что денег недостаточно).
        /// </summary>
        /// <param name="money"> Выдаваемая сумма.</param>
        /// <returns>Сумма денег, взятая из кармана, или 0, если денег не хватает (или если 
        /// сумма не действительна)</returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says: {amount} isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} says: I don't have enought cash to give you {amount}");
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Получает деньги, добавляя их в свой карман (или выводит сообщение на консоль, если сумма недействительна).
        /// </summary>
        /// <param name="amount">Полученная сумма</param>
        public void RecieveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says: {amount} isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }

        /// <summary>
        /// Выводит значение моих полей Name, Cash на консоль
        /// </summary>
        public void WrtiteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash}$.");
        }
    }
}
