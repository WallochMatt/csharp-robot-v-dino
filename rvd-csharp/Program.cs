

using rvd_csharp;

//Change the argument values to create your own objects! Ex: Dinosaur("Here", 10);

Dinosaur gawr = new Dinosaur("Gurrrra", 25);

Weapon laser = new Weapon("Laser Beam", 20);
Robot mrRoboto = new Robot("Mr.Roboto", laser);

Battlefield game = new Battlefield(mrRoboto, gawr);

game.runGame();
