using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    abstract class Character {
        public int HP { get; private set; }
        
        /// <summary>
        /// 何らかの方法で攻撃する。
        /// </summary>
        public abstract void Attack();

        /// <summary>
        /// 何らかの方法で回復する。
        /// </summary>
        public abstract void Heal();

        /// <summary>
        /// オートモードで戦闘する。
        /// </summary>
        public void DoAuto() {
            if (HP >= 60)
                Attack();
            else
                Heal();
        }

        public Character(int hp) {
            this.HP = hp;
        }
    }
}
