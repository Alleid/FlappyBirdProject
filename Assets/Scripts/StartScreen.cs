using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartScreen : MonoBehaviour
{

    public event Action PlayButtonCliked;

    public void StartGame()
    {
        if (PlayButtonCliked != null)
        {
            PlayButtonCliked.Invoke();
        }
    }
}
