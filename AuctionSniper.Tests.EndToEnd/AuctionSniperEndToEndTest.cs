using System;
using AuctionSniper.Tests.Common;
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
}