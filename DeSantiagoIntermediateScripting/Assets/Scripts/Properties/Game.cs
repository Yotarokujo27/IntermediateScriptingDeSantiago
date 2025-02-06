using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void start()
    {
        Player myPlayer = new Player();


        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}
