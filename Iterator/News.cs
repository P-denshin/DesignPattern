using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    class News {
        /// <summary>
        /// 記事のタイトル
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 記事のURL
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// 記事の概要
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ニュースを表示する。
        /// </summary>
        public void Show() {
            Console.WriteLine("タイトル：" + Title);
            Console.WriteLine("URL:" + URL);
            Console.WriteLine(Description);
        }
    }
}
