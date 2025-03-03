using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    private void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy1 = new Enemy1();
        Humanoid orc = new Orc();

        human.Yell();
        enemy1.Yell();
        orc.Yell();
    }
    
}
