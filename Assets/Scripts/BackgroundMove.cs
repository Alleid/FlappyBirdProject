using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] private BirdMove _birdMove;
    [SerializeField] private float _xOffset;
    [SerializeField] private Animator _animator;

    private void Update()
    {
        var position = transform.position;
        position.x = _birdMove.transform.position.x + _xOffset;
        transform.position = position;

    }
}
