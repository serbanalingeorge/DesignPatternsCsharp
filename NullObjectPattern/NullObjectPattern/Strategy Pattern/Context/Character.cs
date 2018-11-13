using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Strategy_Pattern.Context
{
    public class Character
    {
        private IWeapon weapon;

        public void SetWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }

        public void Attack()
        {
            weapon.Use();
        }
    }
}
