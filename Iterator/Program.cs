using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    class Program {
        static void Main(string[] args) {
            NewsList nl = new NewsList();

            nl.Add(
                new News() {
                    Title = "本日の天気",
                    URL = "http://www.~~~~.com/xxxxxx",
                    Description = "全国的に晴れやくもり、または雨でしょう"
                }
                );

            nl.Add(
                new News() {
                    Title = "ゆるゆりがすごい",
                    URL = "http://www.$$$$.com/xxxxx",
                    Description = "千鶴が可愛いと話題に"
                }
                );

            nl.Add(
                new News() {
                    Title = "ポテチが気が狂ってる",
                    URL = "http://www.%%%%%.com/xxxxx",
                    Description = "ショートケーキ味が期間限定で発売"
                }
                );

            IEnumerator<News> it = nl.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.Show();
                Console.WriteLine();
            }


            foreach (News n in nl) {
                n.Show();
                Console.WriteLine();
            }
        }
    }
}
