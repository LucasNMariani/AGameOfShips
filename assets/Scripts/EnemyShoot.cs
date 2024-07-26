using UnityEngine;
using UnityEngine.Serialization;

public class EnemyShoot : FallingController
{
    [Header("Distance")]
    [SerializeField]
    protected float _distanceFromPlayer = 10;
    [SerializeField]
    protected float _attackDistance = 40;

    [Header("Bullet")]
    [SerializeField]
    protected float _timeToShoot = 1f;
    [SerializeField]
    protected GameObject _ballPreFab;

    private float _timer;

    public override void Update()
    {
        base.Update();
        _distanceFromPlayer = Vector3.Distance(GameManager.instance.Player.transform.position, transform.position);

        if (_distanceFromPlayer < _attackDistance)
        {
            _timer += Time.deltaTime;

            if (_timer > _timeToShoot)
            {
                Instantiate(_ballPreFab, transform.position, Quaternion.Euler(0, 0, 0));
                _timer = 0;
            }
        }
    }
}
