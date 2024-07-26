using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNormal : MonoBehaviour
{
    private Player player;

    public float viewDistance = 1.5f;
    public float attackDistance = 0.3f;
    public float speed = 1;
    public float countHits = 3;
    public bool attacking;

    public float _timer;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccionToPlayer = player.transform.position - transform.position;
        direccionToPlayer.Normalize();

        float distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);
        Debug.DrawRay(transform.position, direccionToPlayer, Color.red);

        //Mov enemy
        if (distanceToPlayer < viewDistance)
        {
            transform.position += direccionToPlayer * speed * Time.deltaTime;

            if (distanceToPlayer < attackDistance)
            {
                speed = 0;
                attacking = true;
            }
            else
            {
                speed = 3;
                attacking = false;
            }
        }
    }
}
