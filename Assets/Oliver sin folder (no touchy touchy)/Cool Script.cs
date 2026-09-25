using System;
using UnityEngine;

public class CoolScript : MonoBehaviour
{
    public string Game;
    public bool crash = true;

    private void Start()
    {
        Game = "very good and working, 0 bugs";
    }

    private void Update()
    {
        while (crash)
        {
            print("I'm crashing");
        }   
    }
}
