using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    class NewsList : IEnumerable<News> {
        List<News> newsList;

        /// <summary>
        /// 指定したインデックスにあるニュースを取得する。
        /// </summary>
        /// <param name="x">インデックス</param>
        /// <returns>指定したインデックスにある要素</returns>
        public News this[int x] {
            get {
                return newsList[x];
            }
        }

        /// <summary>
        /// ニュースの数を取得する。
        /// </summary>
        public int Length {
            get {
                return newsList.Count;
            }
        }

        /// <summary>
        /// ニュースを追加する。
        /// </summary>
        /// <param name="ns">追加するニュース</param>
        public void Add(News ns) {
            newsList.Add(ns);
        }

        /// <summary>
        /// ニュースリストを初期化する。
        /// </summary>
        public NewsList() {
            this.newsList = new List<News>();
        }

        /// <summary>
        /// ニュースリストの列挙子を取得する。
        /// </summary>
        /// <returns>ニュースリストの列挙子</returns>
        public IEnumerator<News> GetEnumerator() {
            return new NewsEnumerator(this);
        }

        /// <summary>
        /// ニュースリストの列挙子を取得する。
        /// </summary>
        /// <returns>ニュースリストの列挙子</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
