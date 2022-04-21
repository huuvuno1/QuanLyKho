using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho
{
    internal class MyApplication
    {
        private static Dictionary<string, object> store = new Dictionary<string, object>();

        public static void Set(string key, object value)
        {
            store[key] = value;
        }

        public static object Get(string key)
        {
            return store[key];
        }
    }
}
