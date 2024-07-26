using UnityEngine;

public abstract class FallingController : MonoBehaviour
{
    [Header("Falling Controller")]
    [SerializeField]
    protected float _speed;
    [SerializeField]
    protected float _timeToDestroy = 15;

    public virtual void Update()
    {
        transform.position += Vector3.down * _speed * Time.deltaTime;
        _timeToDestroy -= Time.deltaTime;
        if (_timeToDestroy <= 0)
        {
            Destroy(gameObject);
        }
    }
}
