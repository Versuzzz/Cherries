using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class WalkRight : MonoBehaviour { //Почему walkleft не выглядит так же?

    public Transform Player;
    public Animation WalkRight_;
    public float lastcord;
    int a=1, b=1;
    public void Update()
    {
        int bd = a + b;
        var coord = Player.position.x;
        WalkRight_.Play("WalkRight");
       
    }
}
