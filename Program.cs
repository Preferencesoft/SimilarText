#undef TEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimilarText
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;

#if TEST
            //Test
            SimilarString ss = new SimilarString();
            double p = 0;
            int n = 0;
            s1 = "AAXBBBBBBBBBBBXCC";
            s2 = "AAYBBBBBBBBBBBYCC";
            p = 0;
            n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}   expected: 15   percent: 88.235294117647058 ", n, p);

            s1 = "dddddddddddddddddddddddggggggggggggggggguuuuuuuuuuuuuuuuuuuuuueeeeeeeeeeeeeeee234234ERZRZRSFSDFitrutroiut";
            s2 = "ddddddddddgggggggggggggggggggggggggggggguuuuuuuuuuuuuuuuuuuuuuuudfsfsfsdkjfhsdkfsk";
            p = 0;
            n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}   expected: 51   percent: 54.545454545454547 ", n, p);
            s1 = "A";
            s2 = "A";
            p = 0;
            n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}   expected: 1   percent: 100 ", n, p);
            s1 = "";
            s2 = "";
            p = 0;
            n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}   expected: 0   percent: 0 ", n, p);
            s1 = "";
            s2 = "A";
            p = 0;
            n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}   expected: 0   percent: 0 ", n, p);
            s1 = "A";
            s2 = "AB";
            p = 0;
            n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}   expected: 1   percent: 66.666666666666671 ", n, p);
            s1 = "aghjbklmcuio1ert";
            s2 = "aiopbghkctyu1oplj=========================";
            p = 0;
            n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}   expected: 4   percent: 13.793103448275861 ", n, p);
            s1 = "AEZZERZERZRgGGGggggggggggggggggggggggggggggggg35353434GGGGGGGG67868jglfdklfjdlksfjsdkldjdfkdljjjjjjjjjjjsdkfjdsklfsdkfjjjjjjjjjjjskdfjsdlkfsdkl";
            s2 = "AZERZREZ234242gggggggg3453535ggggggggfklhjfgklhjfglkhjffhjghfjlhf====dflgkdkfghdjfg=========dfgkdfghdjkgdkjghdkjgkd";
            p = 0;
            n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}   expected: 41   percent: 31.782945736434108 ", n, p);
            s1 = "AAABBBCCC";
            s2 = "AADBBBDCC";
            p = 0;
            n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}   expected: 7   percent: 77.777777777777771 ", n, p);
           
            Console.In.ReadLine();
#else
            s1 = Console.In.ReadLine();
            s2 = Console.In.ReadLine();
            SimilarString ss = new SimilarString();
            double p = 0;
            int n = ss.SimilarText(s1, s2, out p);
            Console.Out.WriteLine("{0}   percent:{1}", n, p);
            Console.In.ReadLine();
#endif
        }
    }
}
