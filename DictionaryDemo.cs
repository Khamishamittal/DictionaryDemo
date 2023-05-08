using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProject
{
    //dictionary is a generic collection that consist of a elements as key value pair.
    // it is not sorted order.
    public class DictionaryDemo
    {

        Dictionary<string, string> dic = new Dictionary<string, string>();
        public void Display()
        {
            dic.Add("1", "olaaaaaaaaaa");
            dic.Add("24", "adityyyyyyyyyyyyyyyyyyyyy");
            dic.Add("22", " khamisha");
            dic.Add("5", "Riyaaaaaaaaaa");
            dic.Add("53", "dragon");
            Console.WriteLine(dic["24"]);
            Console.WriteLine(dic["1"]);
            dic["22"] = "Mittal";
            foreach (KeyValuePair<string, string> key in dic)
            {

                Console.WriteLine("{0} : {1}", key.Key, key.Value);
            }

            Dictionary<int,string>dictionary= new Dictionary<int,string>();
            dictionary.Add(1, "khamishaaaaaaaaaa");
            dictionary[2]= "bkbkbikb";
            dictionary.Remove(2);
            if (dictionary.ContainsKey(1))
                dictionary[1] = "Harshhhhhuyyyyyyyyyy";
            foreach (KeyValuePair<int, string> key in dictionary)
            {

                Console.WriteLine("{0} : {1}", key.Key, key.Value);
            }



        }
    }
}
