using System;

namespace MyDictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int,string> m1 = new MyDictionary< int,string> ();
            m1.Add(4, "Mehmet Kolcu");
            m1.Add(1, "Hasan Günbatar");
            m1.Add(12, "Kerem Yüce");
            m1.Add(13, "Ayşe Adanalı");

            m1.yazdır();
        }
    }
}
