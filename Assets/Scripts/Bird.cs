using Edgar.Unity.Examples;
using System;
using UnityEngine;

[RequireComponent(typeof(BirdMove))]
[RequireComponent(typeof(BirdCollisionHandler))]
[RequireComponent(typeof(ScoreCounter))]
public class Bird : MonoBehaviour
{

    private BirdCollisionHandler _birdCollisionHandler;
    private BirdMove _birdMove;
    private ScoreCounter _scoreCounter;

    public event Action GameOver;

    private void OnEnable()
    {
        _birdCollisionHandler.CollisionDetect += ProcessCollision;
    }

    private void Awake()
    {
        _birdCollisionHandler = gameObject.GetComponent<BirdCollisionHandler>();
        _birdMove = gameObject.GetComponent<BirdMove>();
        _scoreCounter = gameObject.GetComponent<ScoreCounter>();
    }

    private void ProcessCollision(IInteractable interactable)
    {
        if(interactable is Pipe || interactable is Ground)
        {
            if(GameOver != null)
            {
                GameOver.Invoke();
            }
        }else if(interactable is Coin)
        {
            _scoreCounter.AddScore();
        }
    }

    internal void Reset()
    {
        _scoreCounter.Reset();
        _birdMove.Reset();
    }

    private void OnDisable()
    {
        _birdCollisionHandler.CollisionDetect -= ProcessCollision;
    }
}
