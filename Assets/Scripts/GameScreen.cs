using System;
using UnityEngine;

public class GameScreen : MonoBehaviour
{

    public event Action PauseButtonCliked;

    public void PauseGame()
    {
        if (PauseButtonCliked != null)
        {
            PauseButtonCliked.Invoke();
        }
    }
}

