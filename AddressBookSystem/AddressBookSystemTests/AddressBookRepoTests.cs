using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBookSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem.Tests
{
    [TestClass()]
    public class AddressBookRepoTests
    {
        AddressBookRepo repo = new AddressBookRepo();

        [TestMethod()]
        public void DisplayAddressBookTest()
        {
            Console.WriteLine("Display of AddressBook");
            repo.DisplayAddressBook();
        }

        [TestMethod()]
        public void DisplayPersonDetail1Test()
        {
            Console.WriteLine("Display of PersonDetail1");
            repo.DisplayPersonDetail1();
        }

        [TestMethod()]
        public void DisplayAddress_Book1Test()
        {
            Console.WriteLine("Display of Address_Book1");
            repo.DisplayAddress_Book1();
        }

        [TestMethod()]
        public void DisplayPersonTypes1Test()
        {
            Console.WriteLine("Display of PersonTypes1");
            repo.DisplayPersonTypes1();
        }

        [TestMethod()]
        public void DisplayPersonsDetail_Type1Test()
        {
            Console.WriteLine("Display of PersonsDetail_Type1");
            repo.DisplayPersonsDetail_Type1();
        }

        [TestMethod()]
        public void DisplayEmployee_Department1Test()
        {
            Console.WriteLine("Display of Employee_Department1");
            repo.DisplayEmployee_Department1();
        }

        [TestMethod()]
        public void UpdateDetailsTest()
        {
            string expected = "Updated Email_ID";
            string address = repo.UpdateDetails();
            Assert.AreEqual(expected, address);
        }
    }
}