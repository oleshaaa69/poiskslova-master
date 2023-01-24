using WindowsFormsApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace UnitTestReg
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testauthorization()
        {
            User user = new User();
            List<User> list = new List<User>();
            list = Serialize.LoadFromFile("users.txt");
            string login = "admin1111111";
            string password = "admin111111";
            user.login = login;
            user.password = password;
            list.Add(user);
            bool good = false;
            foreach (var usr in list)
            {
                if (usr.login == login && usr.password == password)
                {
                    good = true;
                }
            }
            Assert.AreEqual(good, true);
        }
        [TestMethod]
        public void Testregistration()
        {
            List<User> list = new List<User>();
            list = Serialize.LoadFromFile("users.txt");
            string login = "111";
            string password = "111";
            Boolean good = false;
            foreach (var usr in list)
            {
                if (usr.login == login && usr.password == password)
                {
                    good = true;
                }
            }
            Assert.AreEqual(good, true);
        }
        [TestMethod]
        public void TestAuthFalse()
        {
            List<User> list = new List<User>();
            list = Serialize.LoadFromFile("users.txt");
            string login = "admin55";
            string password = "admin55";
            bool good = false;
            foreach (var usr in list)
            {
                if (usr.login == login && usr.password == password)
                {
                    good = true;
                }
            }
            Assert.AreEqual(good, false);
        }
        [TestMethod]
        public void TestPoisk()
        {
            Form1 k = new Form1();
            int c = 0;
            string pred = "маму люблю";
            string isk = "маму";
            char[] words = pred.ToCharArray();
            char[] words1 = isk.ToCharArray(); ;
            bool good = false;
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i] == words1[i])
                {
                    good = true;
                    c++;
                }
                if (c == 4)
                {
                    break;
                }
            }
            Assert.AreEqual(good, true);
        }
    }
}
