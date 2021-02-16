using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lab2_3_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SetSizeArray() // ����� ����������� ������ ������
        {
            int size = Lab2_3A.Program.SetSizeArray("3");
            Assert.AreEqual(3, size); // �������� ����������
        }

        [TestMethod]
        public void SetValueArray() // ������������ ������� �������� ������
        {
            int[] arr = new int[1];
            Lab2_3A.Program.SetValueArray(arr, "2021");
            Assert.AreEqual(2021, arr[0]); // �������� ����������
        }

        [TestMethod]
        public void NumMoreZero()
        {
            int[] arr = new int[5] { 1, -2, -3, 4, -5 }; // ����� � ����� ��������� �������
            uint res = 2; // ��������� �� ���� 2
            uint result = Lab2_3A.Program.NumMoreZero(arr);  // ������� ������� �������� ��������
            Assert.AreEqual(res, result); // �������� ����������
        }

        [TestMethod]
        public void DobutokToMinimumModul() // ������� ������� �������� ������, ������������ �� ���������� �� ������� ��������.
        {
            int[] arr = new int[5] { 3, 2, -1, -99, -123 }; // -1 ��������� �� ������� �������
            int result = int.Parse(Lab2_3A.Program.DobutokToMinimumModul(arr)); // �� 3 * 2 = 6
            Assert.AreEqual(6, result); // �������� ����������
        }
    }
}
