using Edgar.Unity.Examples;
using UnityEngine;

public class PipeAndCoin : MonoBehaviour, IInteractable
{

    [SerializeField] private Coin _coin;

    public void CoinIsActive()
    {
        _coin.gameObject.SetActive(true);
    }
}
