using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryMenu;

namespace TestClassLibrary
{
    [TestClass]
    public class DishTests
    {
        public void CreateInstanceWithStringArray()
        {
            Assert.IsNotNull(new Dish(new string[] { "1","1","10" }));
        }
        [TestMethod]
        public void CreateInstanceWithOutParam()
        {
            Assert.IsNotNull(new Dish());
        }
        [TestMethod]
        public void CreateInstanceWithintstringintParam()
        {
            Assert.IsNotNull(new Dish(1,"1",10));
        }
        [TestMethod]
        public void GetStr_1_1_10return()
        {
            Dish dish = new Dish(1, "1", 10);
            string exp = "1;1;10";
            string act = dish.GetStr();
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Equal_truereturn()
        {
            Dish dish1 = new Dish(1, "1", 10);
            Dish dish2 = new Dish(1, "1", 10);
            Assert.IsTrue(dish1.Equals(dish2));
        }
        [TestMethod]
        public void Equal_falsereturn()
        {
            Dish dish1 = new Dish(1, "1", 10);
            Dish dish2 = new Dish(2, "2", 20);
            Assert.IsFalse(dish1.Equals(dish2));
        }
    }
}