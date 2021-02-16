using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2_1_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Rokiv() // Перевіряє чи Declension повертає правильний рядок для кожного числа з масиву
        {
            int[] n = new int[] { 20, 25, 26, 27, 28, 29, 30, 35, 36, 37, 38, 39, 40, 45, 46, 47, 48, 49, 50, 55, 56, 57, 58, 59, 60, 65, 66, 67, 68, 69 };

            for (int i = 0; i < n.Length; i++)
            {
                string result = Lab2_1.Program.Declension(n[i]);
                string str = "Років";
                bool res = string.Equals(result, str);
                Assert.IsTrue(res);
            }
        }
        [TestMethod]
        public void Rik() // Перевіряє чи Declension повертає правильний рядок для кожного числа з масиву
        {
            int[] n = new int[] { 21, 31, 41, 51, 61 };

            for (int i = 0; i < n.Length; i++)
            {
                string result = Lab2_1.Program.Declension(n[i]);
                string str = "Рік";
                bool res = string.Equals(result, str);
                Assert.IsTrue(res);
            }
        }

        [TestMethod]
        public void Roku() // Перевіряє чи Declension повертає правильний рядок для кожного числа з масиву
        {
            int[] n = new int[] { 22, 23, 24, 32, 33, 34, 42, 43, 44, 52, 53, 54, 62, 63, 64 };

            for (int i = 0; i < n.Length; i++)
            {
                string result = Lab2_1.Program.Declension(n[i]);
                string str = "Роки";
                bool res = string.Equals(result, str);
                Assert.IsTrue(res);
            }
        }

        [TestMethod]
        public void Error() // Перевіряє чи Declension повертає правильний рядок для кожного числа з масиву
        {
            int[] n = new int[] { 10, 100, 150, 200 };

            for (int i = 0; i < n.Length; i++)
            {
                string result = Lab2_1.Program.Declension(n[i]);
                string str = "не в діапазоні [20-69]";
                bool res = string.Equals(result, str);
                Assert.IsTrue(res);
            }
        }
    }
}
