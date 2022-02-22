using System;
using DreamVB.Config;

namespace eTxtReader
{
    class cBookInfo
    {

        public static string BookTitle { get; set; }
        public static string BookAuthor { get; set; }
        public static string BookVersion { get; set; }
        public static string Url { get; set; }
        public static string AboutIcon { get; set; }
        public static string BookFolder { get; set; }

        public static void LoadBookInfo(string Filename)
        {
            cfgfile cfg = new cfgfile(Filename);

            BookTitle = cfg.ReadString("bookinfo", "Title");
            BookAuthor = cfg.ReadString("bookinfo", "Author");
            BookVersion = cfg.ReadString("bookinfo", "version");
            Url = cfg.ReadString("bookinfo", "url");
            AboutIcon = BookFolder + cfg.ReadString("bookinfo", "abouticon");
        }
    }
}
