using Edgar.Unity.Examples;
using UnityEngine;

public class DestroyPipe : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IInteractable interactable))
        {
            if (interactable is PipeAndCoin)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
