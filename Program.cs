
using AStar_Algorithm;
using AStar_Algorithm.Matrices;

int[,] matrix = GraphUtils.ReadAdjMatrix(@"E:\c#-projects\console-apps\AStar Algorithm\Matrices\Matrix1.txt");

Utils.LogMatrix(matrix);

Console.WriteLine();


LinkedList<Edge>[] graph = GraphUtils.AdjMatrixToLists(matrix);
Utils.LogGraph(graph);
Console.WriteLine();

PathFinder pathFinder = new PathFinder(graph);
LinkedList<int> path = pathFinder.FindPath(0, 4);
Utils.LogPath(path);

// https://www.youtube.com/watch?v=-L-WgKMFuhE&ab_channel=SebastianLague