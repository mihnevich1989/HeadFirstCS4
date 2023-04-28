using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowDamage
{
    abstract class WeaponDamage
    {
        /// <summary>
        /// содежит вычисленный damage
        /// </summary>
        public int Damage { get; protected set; }

        private int roll;
        /// <summary>
        /// задаем или получаем значение кубика 3d6
        /// </summary>
        public int Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool magic;
        /// <summary>
        /// True если меч волшебный
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        /// <summary>
        /// True если меч огненный
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// вычисляет повреждения в зависимости от текущий свойств
        /// </summary>
        protected abstract void CalculateDamage();

        /// <summary>
        /// конструктор вычисляет повреждения для начального броска и значений magic flaming по умолчанию
        /// </summary>
        /// <param name="startingRoll">начальный бросок кубика 3d6</param>
        public WeaponDamage(int startingRoll)
        {
            this.roll = startingRoll;
            CalculateDamage();
        }
    }
}
