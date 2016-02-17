using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    class Magician : Character {
        public override void Attack() {
            Console.WriteLine("黒魔法で攻撃！");
        }

        public override void Heal() {
            Console.WriteLine("白魔法で回復！");
        }

        public Magician(int hp) : base(hp) { }
    }
}
