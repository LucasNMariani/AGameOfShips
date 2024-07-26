using UnityEngine;

public class CanonBall : MonoBehaviour
{
    [SerializeField] 
    private float _speedBall = 3;
    private float _timer;

    void Update()
    {
        if (_timer > 3f) Destroy(gameObject);
        _timer += Time.deltaTime;
        transform.position += Vector3.up * _speedBall * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Rocas"))
        {
            Destroy(gameObject);
        }
    }
}
