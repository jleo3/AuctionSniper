using System;
using System.Windows.Forms;
using AuctionSniper.Tests.Common;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuctionSniper.Tests.CodedUI
{
    /// <summary>
    /// Summary description for BidAndLoseTest
    /// </summary>
    [CodedUITest]
    public class BidAndLoseTest
    {
        public static string XMPP_HOSTNAME = "localhost";
        public static string SNIPER_ID = "sniper";
        public static string SNIPER_PASSWORD = "sniper";
// ReSharper disable EmptyConstructor
        public BidAndLoseTest()
// ReSharper restore EmptyConstructor
        {
        }

        [TestMethod]
        public void TestAuctionSniperBidsAndLoses()
        {
            StartBiddingIn(new FakeAuctionServer("fake_item"));
            var STATUS_JOINING = "joined";
            Assert.AreEqual(STATUS_JOINING, SniperStatus());
            Application.Exit();
        }

        [TestMethod]
        public void TestAuctionSniperShowsLosingStatus()
        {
            var STATUS_LOST = "lost";
            Assert.AreEqual(STATUS_LOST, SniperStatus());
        }

        private string SniperStatus()
        {
            throw new NotImplementedException();
        }

        private void StartBiddingIn(FakeAuctionServer auction)
        {
            try
            {
                var auctionForm = new AuctionForm(XMPP_HOSTNAME, SNIPER_ID, SNIPER_PASSWORD, auction.GetItemID());
                Application.Run(auctionForm);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
            }
        }
        // Start the application by running with App
        // show status as started
        // 
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }

    internal class AuctionForm : Form
    {
        public AuctionForm(string xmppHostname, string sniperID, string sniperPassword, int getItemID)
        {
            throw new System.NotImplementedException();
        }
    }
}
