using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter: MonoBehaviour
{

    private int _score;

    public event Action<int> ScoreChanged;

    public void AddScore()
    {
        _score++;
        if(ScoreChanged != null)
            ScoreChanged.Invoke(_score);
    }

    public void Reset()
    {
        _score = 0;
        if(ScoreChanged != null)
            ScoreChanged.Invoke(_score);
    }
}
