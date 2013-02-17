using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSniper
{
    class AuctionSniperEndToEndTest
    {
        static FakeAuctionServer Auction = new FakeAuctionServer("item-54321");
        static ApplicationRunner Application = new ApplicationRunner();

    }
    
    class SniperJoinsAuctionUntilAuctionCloses()
    {
        Auction.StartSellingItem();
        Application.StartBiddingIn(Auction);
        Auction.HasReceivedJoinRequestFromSniper();
        Auction.AnnounceClosed();
        Application.ShowsSniperHasLostAuction();
    }
}

/* TODO
-- mspec
-- resharper
-- vsvim
*/