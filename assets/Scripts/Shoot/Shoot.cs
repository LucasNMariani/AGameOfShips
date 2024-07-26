using UnityEngine;

public abstract class Shoot : MonoBehaviour
{
    [SerializeField]
    protected float timeToShoot;
    [SerializeField]
    protected GameObject bulletPrefab;
    [SerializeField]
    protected KeyCode _actionKey = KeyCode.Mouse1;
    [SerializeField]
    protected AudioToPlay _audioType = AudioToPlay.ShootAudio;
    protected float _timer;

    protected virtual void Update()
    {
        _timer += Time.deltaTime;
        if (Input.GetKeyDown(_actionKey) && _timer > timeToShoot) OnShoot();
    }

    protected virtual void OnShoot() 
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 0));
        AudioManager.instance.PlayAudioSFX(_audioType);
        _timer = 0;
    }
}
