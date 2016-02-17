using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    class Swordsman : Character {
        public override void Attack() {
            Console.WriteLine("剣で攻撃！");
        }

        public override void Heal() {
            Console.WriteLine("薬草で回復！");
        }

        public Swordsman(int hp) : base(hp) { }
    }
}
