using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    class NewsEnumerator : IEnumerator<News> {
        private NewsList newsList;
        private int i;

        public NewsEnumerator(NewsList nl) {
            this.newsList = nl;
            i = -1;
        }

        /// <summary>
        /// 次のニュースを取得する。
        /// </summary>
        public News Current {
            get { return newsList[i]; }
        }

        //IEnumerator<out T>がIDisposableを実装してるためについてきたもの
        //Disposeの実装の必要はない（はず）
        public void Dispose() { }

        /// <summary>
        /// 次のニュースを取得する。
        /// </summary>
        object System.Collections.IEnumerator.Current {
            //IEnumerator<out T>がIEnumeratorを実装してるためについてきたもの
            get { return this.Current; }
        }


        /// <summary>
        /// 次のニュースに進める。
        /// </summary>
        /// <returns>次のニュースが存在すればtrue　次のニュースが存在しなければfalse</returns>
        public bool MoveNext() {
            i++;
            //範囲外
            if (i >= newsList.Length) {
                return false;
            }
            return true;
        }

        /// <summary>
        /// ニュース列挙子を初期化する。
        /// </summary>
        public void Reset() {
            i = -1;
        }
    }
}
