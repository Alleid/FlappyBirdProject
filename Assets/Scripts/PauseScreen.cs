using System;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{

    public event Action ExitCliked;
    public event Action Continue;

    public void ExitGame()
    {
        if (ExitCliked != null)
        {
            ExitCliked.Invoke();
        }
    }

    public void ContinerGame()
    {
        if (Continue != null)
        {
            Continue.Invoke();
        }
    }
}
