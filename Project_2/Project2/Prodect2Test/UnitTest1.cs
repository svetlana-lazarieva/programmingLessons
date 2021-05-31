using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project2;

namespace Prodect2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange

            //Act
            Project2.UserForm userForm = new UserForm();
            Project2.ConfigForm confForm = new ConfigForm(userForm);
            confForm.SaveConfig();
            //SaveConfig();

            //Asseert
        }
    }
}
