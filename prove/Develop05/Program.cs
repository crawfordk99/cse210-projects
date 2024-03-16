using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Simple simple = new Simple();
        Eternal eternal = new Eternal();
        Console.WriteLine("Welcome to this goals program. Our goal is to help you to keep track of " +
        "your goals, and to provide that extra little bit of dopamine as you accomplish them. " +
        "This is to help give you that extra little bit of motivation you need to accomplish your goals.\n");
        
       
        // Variables needed for cases
        List<string> goals = new List<string>();
        string fileName = "goals.txt";
        string userInput = "";
        string type = "";
        string goal = "";
        int totalPoints = 0;
        int userTotalPoints = 0;
        int pointsBenchmark = 0;
        int benchmarkBonus = 0;
        int timesCompleted = 0;
        bool continueLoop = true;
        while (continueLoop) {
            Console.WriteLine();
            Console.WriteLine($"Total Points From Goals Today: {userTotalPoints}");
            Console.WriteLine("Please choose a number from the menu.\n" +
            "1. Set new goal\n" +
            "2. Update previous goals\n" +
            "3. Check progress\n" +
            "4. Clear Goal\n" +
            "5. Quit\n");
        
            userInput = Console.ReadLine();
            switch (userInput) {
                case "1":
                        Console.WriteLine("Please enter goal description: ");
                        goal = Console.ReadLine();
                        Console.WriteLine("Choose type of goal\n" +
                        "Simple\n" +
                        "Eternal\n");
                        type = Console.ReadLine();
                        if (type == "Simple") {
                            totalPoints = 0;
                            Console.WriteLine("Please enter desired points benchmark for bonus. The rewards are smaller" +
                            " and will probably take less time so keep the benchmark relatively small.");
                            pointsBenchmark = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("Please enter desired points bonus for reaching benchmark.");
                            benchmarkBonus = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            simple = new Simple(timesCompleted, goal, totalPoints, pointsBenchmark, benchmarkBonus);
                            simple.GoalsToFile();
                            string[] snewGoal = File.ReadAllLines(fileName);
                            goals.Add(snewGoal[0]);
                        }
                        else if (type == "Eternal") {
                            totalPoints= 0;
                            Console.WriteLine("Please enter desired points benchmark for bonus. Keep in mind eternal goals" +
                            " multiply each time you accomplish them so think big with your benchmark!");
                            pointsBenchmark = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter desired points bonus for reaching benchmark.");
                            Console.WriteLine("");
                            benchmarkBonus = int.Parse(Console.ReadLine());
                            eternal = new Eternal(timesCompleted, goal, totalPoints, pointsBenchmark, benchmarkBonus);
                            eternal.GoalsToFile();
                            string [] enewGoal = File.ReadAllLines(fileName);
                            goals.Add(enewGoal[0]);
                        }
                        else {
                            Console.WriteLine("Please enter type as shown in the Menu.");
                        }
                    break;
                case "2":
                    int i = 0;
                    goals.Clear();
                    string[] fileArray = File.ReadAllLines(fileName);
                    goals.AddRange(fileArray);
                    if (goals.Count == 0) {
                        Console.WriteLine("File is empty, please make new goals!\n");
                        break;
                    }
                    Console.WriteLine("Please choose goal by it's number.\n");
                    
                    for (int oldGoal = 0; oldGoal <= goals.Count-1; oldGoal++) {
                        Console.WriteLine($"{i} : {goals[oldGoal]}\n");
                        i++;
                    }
                    i = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{goals[i]}\n");
                    Console.WriteLine("Did you accomplish this goal? Enter yes or no.");
                    string yesOrNo = Console.ReadLine();
                    
                    if (yesOrNo == "yes") {
                        string line = goals[i];
                        if (line.Trim() != "") {
                            string[] parts= line.Split(",");
                            string[] parts2 =parts[0].Split(" ");
                            timesCompleted = int.Parse(parts2[2]);
                            string[] parts3 = parts[1].Split(" ");
                            totalPoints = int.Parse(parts3[3]);
                            type = parts[2];
                            goal = parts[5];
                            pointsBenchmark = int.Parse(parts[4]);
                            benchmarkBonus = int.Parse(parts[3]);
                            if (type.IndexOf("simple") != -1) {
                                timesCompleted++;
                                totalPoints += simple.RewardPoints();
                                userTotalPoints += totalPoints;
                                simple = new Simple(timesCompleted, goal, totalPoints, pointsBenchmark, benchmarkBonus);
                                parts[0] = ($"Times Completed: {timesCompleted},");
                                parts[1] = ($" Total Points: {totalPoints},");
                                goals[i] = "";
                                goals[i] = ($"{parts[0]}{parts[1]}{parts[2]},{parts[3]},{parts[4]},{parts[5]}");
                                Console.WriteLine("");
                            }
                            else if (type.IndexOf("eternal") != -1) {
                                timesCompleted++;
                                totalPoints += eternal.RewardPoints();
                                userTotalPoints += totalPoints;
                                eternal = new Eternal(timesCompleted, goal, totalPoints, pointsBenchmark, benchmarkBonus); 
                                parts[0] = ($"Times Completed: {timesCompleted},");
                                parts[1] = ($" Total Points: {totalPoints},");
                                goals[i] = "";
                                goals[i] = ($"{parts[0]}{parts[1]}{parts[2]},{parts[3]},{parts[4]},{parts[5]}");
                                Console.WriteLine("");
                            }
                            else {
                                Console.WriteLine("Please enter 1 of the choices as written");
                            }
                            
                        }
                    }
                    else if (yesOrNo == "no") {
                        Console.WriteLine("Keep pushing!");
                    }
                    else {
                        Console.WriteLine("Please enter yes or no.");
                    } 
                    File.WriteAllLines(fileName, goals);
                    goals.Clear();
                    break;
                case "3":
                    string[] strings= File.ReadAllLines(fileName);
                    goals.AddRange(strings);
                    foreach (string line in goals) {
                        Console.WriteLine($"{line}");
                    }
                    goals.Clear();
                    break;
                case "4":
                    File.WriteAllText(fileName, string.Empty);
                    Console.WriteLine();
                    break;
                case "5":
                    continueLoop = false;
                    break;
                
            }

        } 
    }
}