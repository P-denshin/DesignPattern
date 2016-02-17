using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    class Program {
        static void Main(string[] args) {
            Character mga = new Magician(100);
            Character mgb = new Magician(40);
            Character swa = new Swordsman(100);
            Character swb = new Swordsman(40);

            mga.DoAuto();
            mgb.DoAuto();
            swa.DoAuto();
            swb.DoAuto();
        }
    }
}
