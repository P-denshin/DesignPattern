using System;

namespace Adapter {
    class Line : IShare{
        void IShare.Share(string s) {
            Console.WriteLine("\"" + s + "\"" + "とLINEに投稿！てかLINEやってる？");
        }
    }
}
