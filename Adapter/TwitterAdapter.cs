using System;

namespace Adapter {
    class TwitterAdapter : Twitter, IShare{
        void IShare.Share(string s) {
            this.Tweet(s);
        }
    }
}
