using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Questions
{
    public class MyItem
    {
        public MyItem(int count, char charValue, char sType)
        {
            Count = count;
            CharValue = charValue;
            SType = sType;
        }
        public int Count { get; set; }
        public char CharValue { get; set; }
        public char SType { get; set; }
    }
    public static class StringsMix
    {
        public static string Execute(string s1, string s2)
        {
            //if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) return "";

            List<char> lowers = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Dictionary<char, int> freqsS1 = new Dictionary<char, int>();
            Dictionary<char, int> freqsS2 = new Dictionary<char, int>();

            //string s1 = "my&friend&Paul has heavy hats! &";
            //string s2 = "my friend John has many many friends &";
            string result = "";

            SetDict(s1, freqsS1, lowers);
            SetDict(s2, freqsS2, lowers);
            freqsS1 = freqsS1.Where(x => x.Value > 1).ToDictionary(x => x.Key, x => x.Value);
            freqsS2 = freqsS2.Where(x => x.Value > 1).ToDictionary(x => x.Key, x => x.Value);

            freqsS1 = freqsS1.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            freqsS2 = freqsS2.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            List<MyItem> myItems = new List<MyItem>();
            List<MyItem> resultItems = new List<MyItem>();

            AddValuesToMyItems(freqsS1, myItems, '1');
            AddValuesToMyItems(freqsS2, myItems, '2');

            myItems = myItems.OrderByDescending(x => x.Count).ToList();

            var hede = myItems.GroupBy(p => p.Count).ToList();

            for (int i = 0; i < hede.Count; i++)
            {
                if (hede[i].Count() > 1)
                {
                    var hede2 = hede[i].GroupBy(x => x.CharValue).ToList();

                    for (int j = 0; j < hede2.Count; j++)
                    {
                        if(hede2[j].Select(x => x).ToList().Count > 1)
                        {
                            var hede3 = hede2[j].Select(x => x).First();
                            hede3.SType = '=';
                            resultItems.Add(hede3);
                        }
                        else
                        {
                            resultItems.Add(hede2[j].First());
                        }
                    }
                }
                else
                {
                    resultItems.Add(hede[i].First());
                }
            }

            resultItems = resultItems.GroupBy(x => x.CharValue).Select(x => x.First()).ToList();
            var hedee = resultItems.GroupBy(x => x.Count).ToList();
            resultItems.Clear();
            foreach (var item in hedee)
            {
                var xxxx = item.OrderBy(x => x.CharValue).ToList();
                var ddd = xxxx.OrderBy(x => x.SType).ToList();
                foreach (var item2 in ddd)
                {
                    resultItems.Add(item2);
                }
            }

            foreach (var item in resultItems)
            {
                result += item.SType + ":" + new String(item.CharValue,item.Count) + "/";
            }

            result = result.Substring(0, result.Length - 1);
            return result;
        }

        public static void ShowDict(Dictionary<char, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine("key: " + item.Key + " - value: " + item.Value);
            }
        }
        public static void SetDict(string s, Dictionary<char, int> dict, List<char> lowers)
        {
            foreach (var item in from item in s where lowers.Contains(item) select item)
            {
                if (dict.Keys.Contains(item))
                {
                    dict[item] += 1;
                }
                else
                {
                    dict[item] = 1;
                }
            }
        }
        public static void AddValuesToMyItems(Dictionary<char, int> dict, List<MyItem> myItems, char stype)
        {
            foreach (var item in dict)
            {
                myItems.Add(new MyItem(item.Value, item.Key, stype));
            }
        }

    }
}
