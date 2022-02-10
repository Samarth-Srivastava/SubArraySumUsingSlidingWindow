class Solution {
    public int solve(List<int> A, int B) {
        int N = A.Count();
        int minSum = int.MaxValue;
        int index = -1;
        int s0 = 0;
        for(int i = 0; i < B; i++){
            s0 = s0 + A[i];
        }
        

        List<int> subArraySum = new List<int>();
        subArraySum.Add(s0);
        int si = 0;
        for(int i = 1; i < N-B+1; i++){
            if(i == 1){
                si = s0 - A[i-1] + A[i+B-1];
            }
            else{
                si = si - A[i-1] + A[i+B-1];
            }
            subArraySum.Add(si);
        }

        for(int s = 0; s < N-B+1; s++){
                int sum = Min(minSum, subArraySum[s]);
                if(sum < minSum){
                    minSum = sum;
                    index = s;
                }
        }
        return index;
    }

    public int Min(int a, int b){
        if(a < b){
            return a;
        }
        return b;
    } 
}
