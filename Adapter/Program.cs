using System;

namespace Adapter {
    class Program {
        static void Main(string[] args) {
            IShare fb = new Facebook();
            IShare ln = new Line();

            fb.Share("安倍首相と繋がりがあります。企業に興味があります。");
            ln.Share("イツメンとスタバでコーヒーわず");

            //今までは上までの実装だったけど、Twitterも使いたくなったから次のように書けるようにした
            IShare tw = new TwitterAdapter();
            tw.Share("キエエエエエェェェェェェェェェエエエエ");
        }
    }
}
