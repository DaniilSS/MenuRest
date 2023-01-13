using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryMenu;

namespace TestClassLibrary
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void CreateInstanceWithStringArray()
        {
            Assert.IsNotNull(new Menu(new string[] {"1;1;10"}));
        }
        [TestMethod]
        public void CreateInstanceWithOutParam()
        {
            Assert.IsNotNull(new Menu());
        }

        [TestMethod]
        public void Add_1_10_1return()
        {
            Menu menu = new Menu();
            string name = "1";
            int cost = 10;
            int exp = 1;
            int act = menu.Add(name,cost);
            Assert.AreEqual(exp,act);
        }

        [TestMethod]
        public void GetStrMenu_return()
        {
            Menu menu = new Menu();
            string name = "1";
            int cost = 10;
            menu.Add(name, cost);
            string[] exp = {"1;1;10"};
            string[] act = menu.GetStrMenu();     
            Assert.AreEqual(exp[0], act[0]);
        }

        [TestMethod]
        public void GetDishByID_1_110return()
        {
            Menu menu = new Menu();
            string name = "1";
            int cost = 10;
            int id = 1;
            menu.Add(name, cost);
            Dish exp = new Dish(1,name, cost);
            Dish act = menu.GetDishByID(id);
            Assert.AreEqual(exp.ID, act.ID);
            Assert.AreEqual(exp.Name, act.Name);
            Assert.AreEqual(exp.Cost, act.Cost);
        }
        [TestMethod]
        public void GetDishByID_2_nullreturn()
        {
            Menu menu = new Menu();
            string name = "1";
            int cost = 10;
            int id = 2;
            menu.Add(name, cost);
            Dish exp = null;
            Dish act = menu.GetDishByID(id);
            Assert.AreEqual(exp, act);
        }
    }
}