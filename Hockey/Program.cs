// See https://aka.ms/new-console-template for more information
using Hockey;


var hockeyMgr = new HockeyManager();

/*
var defender1 = new DefenderHockeyPlayer("Zdeno", "Chára", new DateOnly(1977, 5, 18), 34);
defender1.Hits += 4;

var forward1 = new ForwardHockeyPlayer("Jozef", "Golonka", new DateOnly(1938, 1, 6), 5);
var forward2 = new ForwardHockeyPlayer("Miroslav", "Šatan", new DateOnly(1974, 10, 22), 10);
forward2.GoalsShot += 2;

var goalie1 = new GoalieHockeyPlayer("Ján", "Lašák", new DateOnly(1979, 4, 10), 9);
var goalie2 = new GoalieHockeyPlayer("Jaroslav", "Halák", new DateOnly(1985, 5, 13), 6);
goalie2.GamesWon++;

hockeyMgr.AddNewDefender(defender1);
hockeyMgr.AddNewForward(forward1);
hockeyMgr.AddNewForward(forward2);
hockeyMgr.AddNewGoalie(goalie1);
hockeyMgr.AddNewGoalie(goalie2);*/

hockeyMgr.AddNewDefender("Zdeno", "Chára", new DateOnly(1977, 5, 18), 34);
hockeyMgr.AddNewForward("Jozef", "Golonka", new DateOnly(1938, 1, 6), 5);
hockeyMgr.AddNewForward("Miroslav", "Šatan", new DateOnly(1974, 10, 22), 10);
hockeyMgr.AddNewForward("Juraj", "Slafkovský", new DateOnly(2004, 3, 30), 10);
hockeyMgr.AddNewGoalie("Ján", "Lašák", new DateOnly(1979, 4, 10), 9);
hockeyMgr.AddNewGoalie("Jaroslav", "Halák", new DateOnly(1985, 5, 13), 6);

hockeyMgr.PrintNameAndAgeOfTheYoungestPlayer();

