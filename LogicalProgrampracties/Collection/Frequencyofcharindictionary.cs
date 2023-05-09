using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class Frequencyofcharindictionary
    {
        public void FeqOfcharInDic()
        {
            var str = "varsha";

           Dictionary<char,int> dic = new Dictionary<char,int>();
            foreach(var i in str)
            {
                var count = 0;
                if (dic.ContainsKey(i))
                {
                    count = dic[i];
                }
                dic[i] = count + 1;
            }


            foreach (KeyValuePair<char, int> pair in dic) 
            {
                Console.WriteLine(pair.Key + "=" + pair.Value);

            }
        }


    }
}
