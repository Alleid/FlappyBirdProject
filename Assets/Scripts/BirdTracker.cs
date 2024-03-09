using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTracker : MonoBehaviour
{

    [SerializeField] private BirdMove _birdMove;
    [SerializeField] private float _xOffset;

    private void Update()
    {
        var position = transform.position;
        position.x = _birdMove.transform.position.x + _xOffset;
        transform.position = position;
    }
}
