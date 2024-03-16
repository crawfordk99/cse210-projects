public class Eternal : Goals {
   
    public Eternal() {}

    public Eternal(string goal, int points, int benchmark, int extra) : base(goal, points, benchmark, extra){
        
    }

     public override int RewardPoints() {
        int total = base.GetPoints();
        int level = base.GetBenchMark();
        int plus = base.GetBonus();
        total = total * 3;
        if (total > level) {
            return total * plus;
        }
        else {
            return total;
        }
    }

    public override void GoalsToFile() {
        string fileName = "goals.txt";
        string firstLine = "";
        if (fileName != string.Empty ) {
            string[] oldContent = File.ReadAllLines(fileName);
            File.WriteAllText(fileName, string.Empty);
            firstLine =$"Total Points: {base.GetPoints()}, eternal, {base.GetBonus()}, {base.GetBenchMark()}, {base.GetGoal()}";
            using (StreamWriter fileOutPut = new StreamWriter(fileName)) {
                fileOutPut.WriteLine(firstLine);
                foreach (string line in oldContent) {
                    fileOutPut.WriteLine(line);
                }
            }
        }
    }
}