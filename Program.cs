using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CollectionPrep
{
    struct UserInfo
    {
        public int userId;
        public string userName;
        public UserInfo(int id, string name)
        {
            userId = id;
            userName = name;
        }
    }

    class Program
    {
        static Hashtable userInfoHash;
        static List<UserInfo> userInfoList;
        static Stopwatch sw;// using stopwatch

        static void Main(string[] args)
        {
            userInfoHash = new Hashtable();
            userInfoList = new List<UserInfo>();
            sw = new Stopwatch();
            //Adding
            for(int i = 0; i < 4000000; i++)
            {
                userInfoHash.Add(i, "user" + i);
                userInfoList.Add(new UserInfo( i, "user" + i));
            }

            //Removing
            if(userInfoHash.ContainsKey(0))// check if the hashtable has a key at 0
            {
                userInfoHash.Remove(0); // 0 cuz we set the key as an int.
                // it could be object (even custom type)
            }
      
            //Setting
            if(userInfoHash.ContainsKey(1))//make user the key is exist.
            {
                userInfoHash[1] = "replacement Name";
            }

            //looping
            /*
            foreach (DictionaryEntry entry in userInfoHash)
            {//HashTable is based off the dictionary

                Console.WriteLine("Key: "+ entry.Key + " / Value: "  + entry.Value);
            }
            */

            //Access
            Random randomUserGen = new Random();
            int randomUser = -1;

            sw.Start();
            float startTime = 0;
            float endTime = 0;
            float deltaTime = 0;

            int cycles = 5;
            int cycle = 0;

            while(cycle < cycles)
            {
                randomUser = randomUserGen(3000000,4000000);
                startTime = sw.ElapsedMilliseconds;
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;

                Console.WriteLine("Time take to retrieve " + User);
            }



            Console.ReadKey();

        }


    }
}
