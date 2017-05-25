using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimilarText
{
    class SimilarString
    {

        string str1;
        string str2;

        ///<summary>
        ///This method searches the largest substring common to both strings represented by beginning index and length.
        ///In return:
        ///pos1, pos2: beginning index of the common string in each input string
        ///len: length of the common string
        ///</summary>
        void SimilarStr(int begin1, int len1, int begin2, int len2, out int pos1, out int pos2, out int len)
        {
            pos1 = begin1;
            pos2 = begin2;
            len = 0;
            int end1 = begin1 + len1;
            int end2 = begin2 + len2;
            for (int p = begin1; p < end1; p++)
            {
                for (int q = begin2; q < end2; q++)
                {
                    int r = 0;
                    int pr = p;
                    int qr = q;
                    bool isEqual = true;
                    while (pr < end1 && qr < end2 && isEqual)
                    {
                        if (str1[pr] == str2[qr])
                        {
                            r++;
                        }
                        else
                        {
                            isEqual = false;
                        }
                        pr++;
                        qr++;
                    }
                    if (r > len)
                    {
                        len = r;
                        pos1 = p;
                        pos2 = q;
                    }
                }
            }
        }


        ///<summary>
        ///This method recursively computes the sum of the lengths of the common strings.
        ///</summary>
        int SimilarSum(int begin1, int len1, int begin2, int len2)
        {
            int sum, len;
            int pos1, pos2;
            SimilarStr(begin1, len1, begin2, len2, out pos1, out pos2, out len);
            sum = len;
            if (sum != 0)
            {
                if ((pos1 > begin1) && (pos2 > begin2))
                {
                    sum += SimilarSum(begin1, pos1 - begin1, begin2, pos2 - begin2);
                }
                int e1 = pos1 + len;
                int e2 = pos2 + len;
                //e1 end of the common string in str1
                //e2 end of the common string in str2
                if ((e1 < begin1 + len1) && (e2 < begin2 + len2))
                {
                    sum += SimilarSum(e1, len1 + begin1 - e1, e2, len2 + begin2 - e2);
                }
            }
            return sum;
        }
        public int SimilarText(string s1, string s2, out double percent)
        {
            str1 = s1;
            str2 = s2;
            int len1 = str1.Length;
            int len2 = str2.Length;
            int similar = SimilarSum(0, len1, 0, len2);
            percent = 0.0;
            if (len1 + len2 > 0)
            {
                percent = similar * 200.0 / (len1 + len2);
            }
            return similar;
        }
    }
}
