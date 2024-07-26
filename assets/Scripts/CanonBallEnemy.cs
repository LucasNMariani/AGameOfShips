using Packages.Rider.Editor.Util;
using UnityEngine;

public class CanonBallEnemy : MonoBehaviour
{
    [SerializeField]
    private float _speedBall = 3;
    private float _timer;
    
    void Update()
    {
        _timer += Time.deltaTime;
        transform.position += Vector3.down * _speedBall * Time.deltaTime;
        if (_timer > 3)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var player = collision.GetComponent<Player>();
            player.TakeDamage();
            UIManager.instance.RefreshLifeOnScreen();
            Destroy(gameObject);
        } 
        else if (collision.gameObject.CompareTag("Rocas")) Destroy(gameObject);
    }
}
