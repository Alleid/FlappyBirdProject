using System;
using UnityEngine;
public class EndScreen : MonoBehaviour
{

    public event Action EndButtonCliked;

    public void RestartGame()
    {
        if(EndButtonCliked != null)
        {
            EndButtonCliked.Invoke();
        }
    }
}
