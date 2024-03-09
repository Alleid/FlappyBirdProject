using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    [SerializeField] private Transform _spawnPosition; 
    [SerializeField] private PipeAndCoin _prefab;
    [SerializeField] private int _size;

    private Queue<PipeAndCoin> _poolPipe;

    public IEnumerable<PipeAndCoin> PoolPipe=> _poolPipe;

    private void Awake()
    {
        _poolPipe = new Queue<PipeAndCoin>();
    }

    public PipeAndCoin GetObject()
    {
        if(_poolPipe.Count == 0 && _size>_poolPipe.Count)
        {
            var objects = Instantiate(_prefab);
            objects.transform.parent = _spawnPosition;
            return objects;
        }
        return _poolPipe.Dequeue();
    }

    public void PutObject(PipeAndCoin pipeAndCoin)
    {
        _poolPipe.Enqueue(pipeAndCoin);
        pipeAndCoin.CoinIsActive();
        pipeAndCoin.gameObject.SetActive(false);
    }

    public void Reset()
    {
        _poolPipe.Clear();
    }
}
