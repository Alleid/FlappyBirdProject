using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class BirdMove : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private float _pover;
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _minRotationZ;
    [SerializeField] private float _maxRotationZ;

    private Vector2 _startPosition;
    private Quaternion _minRotation;
    private Quaternion _maxRotation;
    private Rigidbody2D _body;
    private bool isLive;
    
    private void Start()
    {
        isLive = true;
        _startPosition = transform.position;
        _body = GetComponent<Rigidbody2D>();
        _startPosition = transform.position;
        _minRotation = Quaternion.Euler(0, 0, -_minRotationZ);
        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);

    }
    private void Update()
    {
        if (Input.touchCount > 0 && isLive)
        {
            _body.velocity = new Vector2(_speed, _pover);
            transform.rotation = _maxRotation;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, _speedRotation * Time.deltaTime);
    }

    private void BirdIsDead()
    {
        isLive = false;
    }
    public void Reset()
    {
        transform.position = _startPosition;
        isLive = true;
    }
}
