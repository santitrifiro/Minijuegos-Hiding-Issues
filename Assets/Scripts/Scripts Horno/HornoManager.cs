using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornoManager : MonoBehaviour
{
    
    public int n1, n2, n3, n4;
    public int nv1, nv2, nv3, nv4;

    public bool done () {

        return (n1 == nv1) && (n2 == nv2) && (n3 == nv3) && (n4 == nv4);

    }
    public void setnv1 () {

        nv1++;

        if (nv1 > 4) {

            nv1 = 1;

        }

    }

    public void setnv2 () {

        nv2++;

        if (nv2 > 4) {

            nv2 = 1;

        }

    }

    public void setnv3 () {

        nv3++;

        if (nv3 > 4) {

            nv3 = 1;

        }

    }

    public void setnv4 () {

        nv4++;

        if (nv4 > 4) {

            nv4 = 1;

        }

    }

    void Awake()
    {
        
        System.Random random = new System.Random();
        n1 = random.Next(2, 5);
        n2 = random.Next(1, 5);
        n3 = random.Next(1, 5);
        n4 = random.Next(1, 5);

        nv1 = 1;
        nv2 = 1;
        nv3 = 1;
        nv4 = 1;
    }

    void Update()
    {
        
    }
}
