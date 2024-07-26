using UnityEngine;
using UnityEngine.Serialization;

public enum AudioToPlay
{
    ShootAudio,
    ExplotionAudio
}

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField]
    private AudioClip _shootAudio;
    [SerializeField]
    private AudioClip _explotion;
    AudioSource _aSGame;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        _aSGame = GetComponent<AudioSource>();
    }

    public void PlayAudioSFX(AudioToPlay audioType)
    {
        switch (audioType)
        {
            case AudioToPlay.ShootAudio:
                _aSGame.PlayOneShot(_shootAudio);
                break;
            case AudioToPlay.ExplotionAudio:
                _aSGame.PlayOneShot(_explotion);
                break;
        }
    }

}
