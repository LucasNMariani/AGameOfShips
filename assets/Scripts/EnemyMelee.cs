using UnityEngine;

public class EnemyMelee : FallingController
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var player = collision.gameObject.GetComponent<Player>();
            player.TakeDamage();
        }
    }
}
