using UnityEngine;

public class C : MonoBehaviour
{
    char base36(int x)
    {
        if (x < 10) return (char)('0' + x);
        return (char)('A' + x - 10);
    }

    void Start()
    {
        int n = 123;
        string ans = "";
        while (n > 0)
        {
            ans = base36(n % 36) + ans;
            n /= 36;
        }
        Debug.Log(ans);
    }
}
