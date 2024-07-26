using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField]
    protected float speed;
    /*[SerializeField]
    protected GameObject shoot*/
    [SerializeField]
    protected int playerLife;
    [SerializeField]
    protected int boxes;
    [FormerlySerializedAs("levelController")] [SerializeField]
    protected UIManager _uiManager;
    
    Animator _shipAnimator;
    
    void Start()
    {
        GameManager.instance.Player = this;
        _shipAnimator = GetComponent<Animator>();
    }

    // Get from a private variables of player with arrow functions
    public int PlayerLife => playerLife;
    public int PlayerBoxes => boxes;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += Vector3.up * vertical * speed * Time.deltaTime;
        transform.position += Vector3.right * horizontal * speed * Time.deltaTime;
        if (horizontal < -0.01)
        {
            _shipAnimator.SetBool("left", true);
        }
        else if (horizontal > 0.01)
        {
            _shipAnimator.SetBool("right", true);
        }
        else
        {
            _shipAnimator.SetBool("right", false);
            _shipAnimator.SetBool("left", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Rocas")
        {
            playerLife--;
            _uiManager.RefreshLifeOnScreen();
            _shipAnimator.Play("daño");
        }
        else
        {
            _shipAnimator.SetBool("daño", false);
        }
        if (playerLife <= 0)
        {
            _uiManager.alpistePerdiste();
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "recolectable")
        {
            boxes++;
            _uiManager.RefreshBoxesOnScreen();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Victoria")
        {
            _uiManager.SetActiveWinPanel();
        }

    }

    public void TakeDamage()
    {
        playerLife--;
    }
}
