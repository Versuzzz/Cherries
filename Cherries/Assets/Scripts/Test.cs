using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float fallspeed1;

    public void ASD()
    {
        while (!Player.lose)
        {  
            MoveDown.fallspeed = fallspeed1;
        }
    }
}
