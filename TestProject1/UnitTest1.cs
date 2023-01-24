using WindowsFormsApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
    }
}
