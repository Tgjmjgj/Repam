using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    static class Wrapper
    {
        private static string url = "http:\\www.apple.com";
        private static string appleID = "tolia_nagibator7400@mail.ru";
        private static string password = "glavnoe-Mama7400";

        public static string GetUrl()
        {
            return url;
        }

        public static string GetAppleID()
        {
            return appleID;
        }

        public static string GetPassword()
        {
            return password;
        }
    }
}
