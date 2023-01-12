using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RollMagicSwordGame
{
    internal class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

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

        /// <summary>
        /// содежит вычисленный damage
        /// </summary>
        public int Damage { get; private set; }

        /// <summary>
        /// вычисляет повреждения в зависимости от текущий свойств
        /// </summary>
        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
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
        /// конструктор вычисляет повреждения для начального броска и значений magic flaming по умолчанию
        /// </summary>
        /// <param name="startingRoll">начальный бросок кубика 3d6</param>
        public SwordDamage(int startingRoll)
        {
            this.roll = startingRoll;
            CalculateDamage();
        }
    }
}
