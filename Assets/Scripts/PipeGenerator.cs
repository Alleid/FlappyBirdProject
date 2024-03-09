using System.Collections;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{

    [SerializeField] private float _delay;
    [SerializeField] private float _upperPosition;
    [SerializeField] private float _lowerPosition;
    [SerializeField] private ObjectPool _pool;

    private IEnumerator GeneratorPipe()
    {
        var wait = new WaitForSeconds(_delay);
        while (enabled)
        {
            Spawn();
            yield return wait;
        }
    }

    public void SartSpawnPipe()
    {
        StartCoroutine(GeneratorPipe());
    }

    public void StopSpawnPipe()
    {
        StopCoroutine(GeneratorPipe());
        _pool.Reset();
    }

    private void Spawn()
    {
        float spawnPositionY = Random.Range(_lowerPosition, _upperPosition);
        Vector3 spawnPosition = new Vector3(transform.position.x, spawnPositionY, transform.position.z);

        var pipe = _pool.GetObject();
        pipe.gameObject.SetActive(true);
        pipe.transform.position = spawnPosition;
    }
}
