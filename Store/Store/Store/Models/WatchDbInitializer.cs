using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class WatchDbInitializer : DropCreateDatabaseAlways<WatchContext>
    {
        protected override void Seed(WatchContext db)
        {
            db.Watches.Add(new Watch 
            { 
                 Brand = "Casio G-SHOCK",
                 Model = "GMW-B5000D-1E",
                 Descr = "Ever since the first DW-5000C, G-SHOCK has been constantly setting new standards in innovative design, tough structure, and powerful modules.",
                 Price = 220,
                 Gender = 1,
                 Type = 2,
                 Img = "images/watches/1.jpg"
            });
            db.Watches.Add(new Watch
            {
                Brand = "Invicta",
                Model = "IN9204OB",
                Descr = "Stainless steel case with a stainless steel bracelet. Uni-directional rotating stainless steel bezel with a blue top ring. Blue dial with luminous silver-tone hands and dot hour markers.",
                Price = 130,
                Gender = 1,
                Type = 2,
                Img = "images/watches/2.jpg"
            });
            db.Watches.Add(new Watch
            {
                Brand = "Boccia Titanium",
                Model = "3608-02",
                Descr = "Boccia Watches are all solid titanium, not titanium Plated. Titanium is non-allergenic and very friendly to the skin. When Boccia Watches come with a strap, the buckle is also solid titanium.",
                Price = 99,
                Gender = 1,
                Type = 2,
                Img = "images/watches/3.jpg"
            });
            db.Watches.Add(new Watch
            {
                Brand = "Michael Kors",
                Model = "MK6428",
                Descr = "Michael Kors is a world-renowned, award-winning designer of luxury accessories and ready-to-wear with an innate sense of glamour and an unfailing eye for timeless chic",
                Price = 320,
                Gender = 2,
                Type = 2,
                Img = "images/watches/4.jpg"
            });
            db.Watches.Add(new Watch
            {
                Brand = "Luminox",
                Model = "XS.0307.WO",
                Descr = "Sporty Luminox Ladies. Very comfortable Silicon strap. The water resistance is 10 ATM.",
                Price = 270,
                Gender = 2,
                Type = 1,
                Img = "images/watches/5.jpg"
            });
            db.Watches.Add(new Watch
            {
                Brand = "Suunto",
                Model = "SS050414000",
                Descr = "The adaptive training guidance comes in three different modes. Choose the one that best matches your goal: maintain your current fitness level, improve it moderately",
                Price = 190,
                Gender = 2,
                Type = 1,
                Img = "images/watches/6.jpg"
            });
            db.Watches.Add(new Watch
            {
                Brand = "Casio Edifice",
                Model = "EQB-1000D-1AER",
                Descr = "This new high-spec, super-slim model with phone linking capabilities is the latest addition to the EDIFICE lineup of function-packed metal chronographs that are always pushing the limits of timekeeping.",
                Price = 400,
                Gender = 1,
                Type = 1,
                Img = "images/watches/7.jpg"
            });

            base.Seed(db);
        }
    }
}