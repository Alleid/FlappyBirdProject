using Edgar.Unity.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePipe : MonoBehaviour
{

    [SerializeField] private ObjectPool _pool;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractable interactable))
        {
            if (interactable is PipeAndCoin)
            {
                _pool.PutObject(collision.GetComponent<PipeAndCoin>());
            }
        }
    }
}
