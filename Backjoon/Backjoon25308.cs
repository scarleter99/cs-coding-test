public class Backjoon25308
{
    static int n, answer;
    static double x1, y1, x2, y2;
    static int[] inputs;
    static double[,] v;
    static bool[] visited;

    static void dfs(int here, int before, int cnt){
        if(cnt == n){
            answer++;
            return;
        }
        
        x1 = v[here, 0] - v[before, 0];
        y1 = v[here, 1] - v[before, 1];
        for (int i = 0; i < n; i++){
            if (visited[i]){
                continue;
            }

            if (before != -1){
                x2 = v[i, 0] - v[here, 0];
                y2 = v[i, 1] - v[here, 1];
                double cross = x1 * y2 - x2 * y1;
                if (cross > 0){
                    continue;
                }
            }
            visited[i] = true;
            dfs(i, here, cnt + 1);
            visited[i] = false;
        }
    }

    static void Main(string[] args)
    {
        inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        n = 8;
        visited = new bool[n];

        v[0, 0] = 0;
        v[0, 1] = inputs[0];
        v[1, 0] = inputs[1] / Math.Sqrt(2);
        v[1, 1] = inputs[1] / Math.Sqrt(2);
        v[2, 0] = inputs[2];
        v[2, 1] = 0;
        v[3, 0] = inputs[3] / Math.Sqrt(2);
        v[3, 1] = -inputs[3] / Math.Sqrt(2);
        v[4, 0] = 0;
        v[4, 1] = -inputs[4];
        v[5, 0] = -inputs[5] / Math.Sqrt(2);
        v[5, 1] = -inputs[5] / Math.Sqrt(2);
        v[6, 0] = -inputs[6];
        v[6, 1] = 0;
        v[7, 0] = -inputs[7] / Math.Sqrt(2);
        v[7, 1] = inputs[7] / Math.Sqrt(2);

        
        for (int i = 0; i < n; i++){
            visited[i] = true;
            dfs(i, -1, 1);
            visited[i] = false;
        }
    }
}