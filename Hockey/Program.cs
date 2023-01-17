using Hockey;


var hockeyMgr = new HockeyManager();

hockeyMgr.AddNewDefender("Zdeno", "Chára", new DateOnly(1977, 5, 18), 34);
hockeyMgr.AddNewForward("Jozef", "Golonka", new DateOnly(1938, 1, 6), 5);
hockeyMgr.AddNewForward("Miroslav", "Šatan", new DateOnly(1974, 10, 22), 10);
hockeyMgr.AddNewForward("Juraj", "Slafkovský", new DateOnly(2004, 3, 30), 10);
hockeyMgr.AddNewGoalie("Ján", "Lašák", new DateOnly(1979, 4, 10), 9);
hockeyMgr.AddNewGoalie("Jaroslav", "Halák", new DateOnly(1985, 5, 13), 6);

hockeyMgr.PrintNameAndAgeOfTheYoungestPlayer();