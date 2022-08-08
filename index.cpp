#include <iostream>
using namespace std;
//matrix determinant
int determinant(int a[][3], int n)
{
    int result = 0;
    if (n == 1)
        return a[0][0];
    else if (n == 2)
        return a[0][0] * a[1][1] - a[0][1] * a[1][0];
    else
    {
        int sign = 1;
        for (int i = 0; i < n; i++)
        {
            int submatrix[n - 1][n - 1];
            for (int j = 1; j < n; j++)
            {
                int k = 0;
                for (int l = 0; l < n; l++)
                {
                    if (l == i)
                        continue;
                    submatrix[j - 1][k] = a[j][l];
                    k++;
                }
            }
            result += sign * a[0][i] * determinant(submatrix, n - 1);
            sign = -sign;
        }
    }
    return result;
}
int main()
{
    int n, k;
    cin >> n >> k;
    int a[n][n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cin >> a[i][j];
        }
    }
    int result = determinant(a, n);
    cout << result << endl;
    return 0;
}
