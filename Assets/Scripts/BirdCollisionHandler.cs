using Edgar.Unity.Examples;
using System;
using UnityEngine;

[RequireComponent(typeof(Bird))]
public class BirdCollisionHandler : MonoBehaviour
{

    public event Action<IInteractable> CollisionDetect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractable interactable))
        {
            if (CollisionDetect != null)
            {
                CollisionDetect.Invoke(interactable);
            }
        }
    }
}
