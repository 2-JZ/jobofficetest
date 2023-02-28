using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting
{
    [TestClass]
    public class FileManagerTests
    {
        private const string BAD_FILE_NAME = @"c:\windows\bad.verybad";
        private const string GOOD_FILE_NAME = @"c:\Windows\notepad.exe";
        public TestContext TestContext { get; set; }
       
        [TestMethod]
        public void FilenameDoesExist()
        {
                     
            
            //Arrange
            FileManager fileManager = new FileManager();
            bool fromCall;

            //Act

            //var goodFileName = TestContext.Properties["GoodFileName"].ToString();
            //TestContext.WriteLine("checking file " + goodFileName);
            //fromCall = fileManager.IsFileExists(goodFileName);

            TestContext.WriteLine("checking file " + GOOD_FILE_NAME);
            fromCall = fileManager.IsFileExists(GOOD_FILE_NAME);

            //Assert
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FilenameDoesnotExist()
        {
            //Arrange
            FileManager fileManager = new FileManager();
            bool fromCall;

            //Act
            fromCall = fileManager.IsFileExists(@"C:\Windows\Jato.exe");

            //Assert
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void FileNameNullOrEmpty_UsingAttribute()
        {
            //Arrange
            FileManager fileManager = new FileManager();
            //Act
            fileManager.IsFileExists("");
        }

        [TestMethod]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            FileManager fileManager = new FileManager();

            try
            {
                fileManager.IsFileExists("");

            }
            catch (ArgumentNullException)
            {
                return;
            }

            Assert.Fail("Call to isFileExist() dit NOT throw an excetption");

        }


    }
}