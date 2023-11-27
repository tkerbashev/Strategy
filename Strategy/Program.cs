using Strategy;

Console.WriteLine( "Strategy Behavioural Design Pattern example" );

var keepLeft = new KeepLeft();
var keepRight = new KeepRight();

Console.WriteLine("\nTrying to get out of a maze:");

MazeNavigation mazeNavigation = new();
mazeNavigation.Strategy = keepLeft;

mazeNavigation.MakeMove( );
mazeNavigation.MakeMove( );
mazeNavigation.MakeMove( );

mazeNavigation.Strategy = keepRight;
mazeNavigation.MakeMove( );
mazeNavigation.MakeMove( );
mazeNavigation.MakeMove( );
