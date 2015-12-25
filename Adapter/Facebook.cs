using System;

namespace Adapter {
    class Facebook : IShare{
        void IShare.Share(string s) {
            Console.WriteLine("\"" +  s + "\"" + "をFacebookに投稿！いいね！");
        }
    }
}
