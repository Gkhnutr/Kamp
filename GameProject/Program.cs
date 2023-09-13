using GameProject;

Gamer gamer1 = new Gamer();
gamer1.FirstName = "Gökhan";
gamer1.LastName = "Utar";
gamer1.Id = 1;
gamer1.IdentityNumber = 1;
gamer1.DateOfBirth = new DateTime(1999, 08, 15);

GamerManager gamerManager = new GamerManager(new MernisServiceManager());
gamerManager.Add(gamer1);