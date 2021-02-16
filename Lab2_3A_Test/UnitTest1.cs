using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lab2_3_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SetSizeArray() // запит корректного розміру масива
        {
            int size = Lab2_3A.Program.SetSizeArray("3");
            Assert.AreEqual(3, size); // перевірка результату
        }

        [TestMethod]
        public void SetValueArray() // встановлення значень елементів масива
        {
            int[] arr = new int[1];
            Lab2_3A.Program.SetValueArray(arr, "2021");
            Assert.AreEqual(2021, arr[0]); // перевірка результату
        }

        [TestMethod]
        public void NumMoreZero()
        {
            int[] arr = new int[5] { 1, -2, -3, 4, -5 }; // масив з двома додатними числами
            uint res = 2; // результат має бути 2
            uint result = Lab2_3A.Program.NumMoreZero(arr);  // повертає кількість додатних елементів
            Assert.AreEqual(res, result); // перевірка результату
        }

        [TestMethod]
        public void DobutokToMinimumModul() // повертає добуток елементів масиву, розташованих до мінімального за модулем елемента.
        {
            int[] arr = new int[5] { 3, 2, -1, -99, -123 }; // -1 мінімальний за модулем елемент
            int result = int.Parse(Lab2_3A.Program.DobutokToMinimumModul(arr)); // має 3 * 2 = 6
            Assert.AreEqual(6, result); // перевірка результату
        }
    }
}
