using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private Player _player;
    
    // Properties
    public Player Player
    { 
        get => _player;
        set => _player = value;
    } 

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }
}
