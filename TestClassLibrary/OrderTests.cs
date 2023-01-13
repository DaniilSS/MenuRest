using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryMenu;

namespace TestClassLibrary
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void CreateInstanceWithOutParam()
        {
            Assert.IsNotNull(new Order());
        }
        [TestMethod]
        public void Add_1_10_1()
        {
            Order order = new Order();
            Dish dish1 = new Dish(1, "1", 10);
            order.Add(dish1);
            int exp = 10;
            int act = order.Cost;
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Add_1_1_10x2()
        {
            Order order = new Order();
            Dish dish1 = new Dish(1, "1", 10);
            Dish dish2 = new Dish(1, "1", 10);
            order.Add(dish1);
            order.Add(dish2);
            int exp = 20;
            int act = order.Cost;
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Remove_1_1_10()
        {
            Order order = new Order();
            Dish dish1 = new Dish(1, "1", 10);
            Dish dish2 = new Dish(2, "2", 20);
            Dish dishDeleted = new Dish(1, "1", 10);
            order.Add(dish1);
            order.Add(dish2);
            order.Remove(dishDeleted);
            int exp = 20;
            int act = order.Cost;
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void RemoveOne_2_2_20()
        {
            Order order = new Order();
            Dish dish1 = new Dish(1, "1", 10);
            Dish dish2 = new Dish(2, "2", 20);
            Dish dishDeleted = new Dish(2, "2", 20);
            order.Add(dish1);
            order.Add(dish2);
            order.Add(dish2);
            order.RemoveOne(dishDeleted);
            int exp = 30;
            int act = order.Cost;
            Assert.AreEqual(exp, act);
        }
    }
}
