using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Color _spawnerColor = Color.red;
    [SerializeField]
    private Vector2 _spawnSize;
    [SerializeField]
    private GameObject _prefabToSpawn;
    [SerializeField]
    private float _timeToSpawn;

    private float _timer = 0;
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _timeToSpawn)
        {
            float randomX = Random.Range(transform.position.x - _spawnSize.x / 2, transform.position.x + _spawnSize.x / 2);
            Instantiate(_prefabToSpawn);
            _prefabToSpawn.transform.position = new Vector2(randomX, transform.position.y);
            _timer = 0;
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Victoria"))
        {
            Destroy(gameObject);
        }
    }
    
    void OnDrawGizmos()
    {
        Gizmos.color = _spawnerColor;
        Gizmos.DrawWireCube(transform.position, _spawnSize);
    }
}
