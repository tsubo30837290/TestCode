using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class B : MonoBehaviour
{
    void Start()
    {
        int n=7;
        string s = "sptaast";
        string t = "";    
        foreach (char c in s)
        {
            t = new string(t.Where(x => x != c).ToArray());
            t += c;
        }
        Debug.Log(t);
    }
}
