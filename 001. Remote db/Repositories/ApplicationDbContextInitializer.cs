using Remote_db.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.IO;
namespace Remote_db.Repositories
{
    public class ApplicationDbContextInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {

        //public ApplicationDbContextInitializer() { }

        protected override void Seed(ApplicationDbContext context) {
            base.Seed(context);
            SeedHouses(context);
        }

        //public static byte[] setInitializerProfilePicture(string endPath) {
        //    // Setting default avatar for all profiles
        //    string path = AppDomain.CurrentDomain.BaseDirectory + endPath;
        //    FileStream file = new FileStream(path, FileMode.Open);
        //    byte[] avatar = null;
        //    using (var binary = new BinaryReader(file)) {
        //        avatar = binary.ReadBytes((int)file.Length);
        //    }
        //    return avatar;
        //}

        public static void SeedHouses(ApplicationDbContext context) {
            // Create the users
            UserStore<ApplicationUser> store = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> manager = new UserManager<ApplicationUser>(store);


            House Nova = new House { HouseName = "Nova", Opens = new TimeSpan(06, 00, 00), Closes = new TimeSpan(23, 00, 00) };            
            House Lang = new House { HouseName = "Långhuset", Opens = new TimeSpan(00, 00, 00), Closes = new TimeSpan(23, 59, 59) };
            House Teknik = new House { HouseName = "Teknikhuset", Opens = new TimeSpan(00, 00, 00), Closes = new TimeSpan(23, 59, 59) };
            House Gymnastik = new House { HouseName = "Gymnastikhuset", Opens = new TimeSpan(00, 00, 00), Closes = new TimeSpan(23, 59, 59) };
            House Forum = new House { HouseName = "Forumhuset", Opens = new TimeSpan(00, 00, 00), Closes = new TimeSpan(23, 59, 59) };
            House Prisma = new House { HouseName = "Prismahuset", Opens = new TimeSpan(00, 00, 00), Closes = new TimeSpan(23, 59, 59) };
            House Bilbergska = new House { HouseName = "Bilbergska", Opens = new TimeSpan(00, 00, 00), Closes = new TimeSpan(23, 59, 59) };
            House Test = new House { HouseName = "Test", Opens = new TimeSpan(00, 00, 00), Closes = new TimeSpan(23, 59, 59) };
            context.Houses.AddRange(new[] {Nova, Lang, Teknik, Gymnastik, Forum, Prisma, Bilbergska, Test });
            context.SaveChanges();

            HouseRoom N2037 = new HouseRoom { Id = "N2037", HouseId = Nova.Id, Projector = true, WhiteBoard = true };
            HouseRoom L111 = new HouseRoom { Id = "L1112", HouseId = Lang.Id, Projector = true, WhiteBoard = true };
            HouseRoom T133 = new HouseRoom { Id = "T133", HouseId = Teknik.Id, Projector = true, WhiteBoard = true };
            HouseRoom G108 = new HouseRoom { Id = "G108", HouseId = Gymnastik.Id, Projector = false, WhiteBoard = true };
            HouseRoom F138 = new HouseRoom { Id = "F138", HouseId = Forum.Id, Projector = true, WhiteBoard = true };
            HouseRoom P104 = new HouseRoom { Id = "P104", HouseId = Prisma.Id, Projector = false, WhiteBoard = true };
            HouseRoom B187 = new HouseRoom { Id = "B187", HouseId = Bilbergska.Id, Projector = false, WhiteBoard = false };
            context.Rooms.AddRange(new[] { N2037, L111, T133, G108, F138, P104, B187 });
            context.SaveChanges();

            AvailableTimes Time1 = new AvailableTimes { RoomId = N2037.Id, From = new TimeSpan(09, 00, 00), To = new TimeSpan(10,00,00) };
            AvailableTimes Time2 = new AvailableTimes { RoomId = L111.Id, From = new TimeSpan(09,00,00) , To = new TimeSpan(10,00,00) };
            AvailableTimes Time3 = new AvailableTimes { RoomId = T133.Id, From = new TimeSpan(09,00,00) , To = new TimeSpan(10,00,00) };
            AvailableTimes Time4 = new AvailableTimes { RoomId = G108.Id, From = new TimeSpan(09, 00, 00), To = new TimeSpan(10, 00, 00) };
            AvailableTimes Time5 = new AvailableTimes { RoomId = F138.Id, From = new TimeSpan(09, 00, 00), To = new TimeSpan(10, 00, 00) };
            AvailableTimes Time6 = new AvailableTimes { RoomId = P104.Id, From = new TimeSpan(09, 00, 00), To = new TimeSpan(10, 00, 00) };
            AvailableTimes Time7 = new AvailableTimes { RoomId = B187.Id, From = new TimeSpan(09, 00, 00), To = new TimeSpan(10, 00, 00) };
            context.FreeIntervals.AddRange(new[] { Time1, Time2, Time3, Time4, Time5, Time6, Time7 });
            context.SaveChanges();
            //ApplicationUser eliasU = new ApplicationUser {
            //    UserName = "elias@noodler.com",
            //    Email = "elias@noodler.com",
            //};
            //manager.Create(eliasU, "password");

            //ApplicationUser nicoU = new ApplicationUser {
            //    UserName = "nico@noodler.com",
            //    Email = "nico@noodler.com"
            //};
            //manager.Create(nicoU, "password");

            //ApplicationUser oskarU = new ApplicationUser {
            //    UserName = "oskar@noodler.com",
            //    Email = "oskar@noodler.com"
            //};
            //manager.Create(oskarU, "password");

            //ApplicationUser randomU = new ApplicationUser {
            //    UserName = "random@noodler.com",
            //    Email = "random@noodler.com"
            //};
            //manager.Create(randomU, "password");
            //ApplicationUser corazonU = new ApplicationUser {
            //    UserName = "corazon@noodler.com",
            //    Email = "corazon@noodler.com"
            //};
            //manager.Create(corazonU, "password");

            //ApplicationUser andreasU = new ApplicationUser {
            //    UserName = "andreas@noodler.com",
            //    Email = "andreas@noodler.com"
            //};
            //manager.Create(andreasU, "password");

            //ApplicationUser mathiasU = new ApplicationUser {
            //    UserName = "mathias@noodler.com",
            //    Email = "mathias@noodler.com"
            //};
            //manager.Create(mathiasU, "password");
            //ApplicationUser lightU = new ApplicationUser {            //    UserName = "light@noodler.com",
            //    Email = "light@noodler.com"
            //};
            //manager.Create(lightU, "password");
            //ApplicationUser hakU = new ApplicationUser {
            //    UserName = "hak@noodler.com",
            //    Email = "hak@noodler.com"
            //};
            //manager.Create(hakU, "password");
            //ApplicationUser alfonsU = new ApplicationUser {
            //    UserName = "alfons@noodler.com",
            //    Email = "alfons@noodler.com"
            //};
            //manager.Create(alfonsU, "password");

            //// Define friendships
            //FriendModels friends1 = new FriendModels {
            //    UserId = nicoU.Id,
            //    FriendId = oskarU.Id,
            //    FriendCategory = category1.Id
            //};
            //FriendModels friends2 = new FriendModels {
            //    UserId = nicoU.Id,
            //    FriendId = eliasU.Id,
            //    FriendCategory = category2.Id
            //};
            //FriendModels friends3 = new FriendModels {
            //    UserId = eliasU.Id,
            //    FriendId = corazonU.Id,
            //    FriendCategory = category3.Id
            //};
            //FriendModels friends4 = new FriendModels {
            //    UserId = oskarU.Id,
            //    FriendId = randomU.Id,
            //    FriendCategory = category1.Id
            //};
            //FriendModels friends5 = new FriendModels {
            //    UserId = oskarU.Id,
            //    FriendId = alfonsU.Id,
            //    FriendCategory = category1.Id
            //};
            //FriendModels friends6 = new FriendModels {
            //    UserId = eliasU.Id,
            //    FriendId = lightU.Id,
            //    FriendCategory = category1.Id
            //};
            //FriendModels friends7 = new FriendModels {
            //    UserId = andreasU.Id,
            //    FriendId = eliasU.Id,
            //    FriendCategory = category1.Id
            //};
            //FriendModels friends8 = new FriendModels {
            //    UserId = nicoU.Id,
            //    FriendId = hakU.Id,
            //    FriendCategory = category1.Id
            //};

            //context.Friends.AddRange(new[] { friends1, friends2, friends3, friends4, friends5, friends6, friends7, friends8 }); // Add friendships
            //context.SaveChanges();
        }
    }
}
