using System;

namespace Adapter {
    class Twitter {
        public void Tweet(String s) {
            Console.WriteLine("\"" + s  + "\"" + "ってツイートしたよ。");
        }

        public void Like(String s) {
            Console.WriteLine("\"" + s + "\"" + "をいいねしたよ。");
        }
    }
}
