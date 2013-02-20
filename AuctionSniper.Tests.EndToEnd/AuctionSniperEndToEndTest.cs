using System;
using Machine.Specifications;

// ReSharper disable InconsistentNaming 
// ReSharper disable CheckNamespace
namespace AuctionSniper.Tests.EndToEnd
{
    public class AuctionSniperEndToEndTest
    {
        static FakeAuctionServer Auction = new FakeAuctionServer("item-54321");
        static ApplicationRunner Application = new ApplicationRunner();

        private It will_execute_each_step = () => 
            {
                Auction.StartSellingItem();
                Application.StartBiddingIn(Auction);
                Auction.HasReceivedJoinRequestFromSniper();
                Auction.AnnounceClosed();
                Application.ShowsSniperHasLostAuction();
            };
    }

    internal class ApplicationRunner
    {
        public void StartBiddingIn(FakeAuctionServer auction)
        {
            throw new NotImplementedException();
        }

        public void ShowsSniperHasLostAuction()
        {
            throw new NotImplementedException();
        }
    }

    internal class FakeAuctionServer
    {
        public FakeAuctionServer(string item)
        {
            throw new NotImplementedException();
        }

        public void StartSellingItem()
        {
            throw new NotImplementedException();
        }

        public void HasReceivedJoinRequestFromSniper()
        {
            throw new NotImplementedException();
        }

        public void AnnounceClosed()
        {
            throw new NotImplementedException();
        }
    }
}