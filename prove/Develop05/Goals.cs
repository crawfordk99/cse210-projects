public abstract class Goals {
    private string _goal;
    private int _points;
    private int _benchmark;
    private int _extra;

    public Goals() {}

    public Goals(string goal, int points, int benchmark, int extra) {
        _goal = goal;
        _points = points;
        _benchmark = benchmark;
        _extra = extra;
    }

    public abstract void GoalsToFile();

    public abstract int RewardPoints();

    public string GetGoal() {
        return _goal;
    }        
    
    public int GetPoints() {
        return _points;
    }
        
    public int GetBenchMark() {
        return _benchmark;
    }

    public int GetBonus() {
        return _extra;
    }
    public int ProgressToBenchMark() {
        return GetBenchMark() - GetPoints();
    }
}
