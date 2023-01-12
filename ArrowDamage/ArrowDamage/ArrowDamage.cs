using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ArrowDamage
{
    internal class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

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
        public decimal Damage { get; private set; }

        /// <summary>
        /// вычисляет повреждения в зависимости от текущий свойств
        /// </summary>
        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) baseDamage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
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
        public ArrowDamage(int startingRoll)
        {
            this.roll = startingRoll;
            CalculateDamage();
        }
    }
}
