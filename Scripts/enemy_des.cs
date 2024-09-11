
using UnityEngine;

public class enemy_des : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("shield"))
        {
            anim.SetTrigger("enemy_death");
        }
    }
    public void enemy_death()
    { Destroy(gameObject); }
}
