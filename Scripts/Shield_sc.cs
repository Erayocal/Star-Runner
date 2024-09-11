
using UnityEngine;

public class Shield_sc : MonoBehaviour
{
    private EdgeCollider2D EdgeCollider;
    private Animator anim;
    [SerializeField] private AudioSource astsound;
    private void Start()
    {
        anim= GetComponent<Animator>();
        EdgeCollider= GetComponent<EdgeCollider2D>();
    }
    private void Update()
    {
        if (Map_sc.instance.ck == false)
        {
            anim.SetTrigger("astdes");
        }
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("shield"))
        {
            anim.SetTrigger("astdes");
            astsound.Play();
            EdgeCollider.enabled = !EdgeCollider.enabled;

        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("shield"))
        {
            EdgeCollider.enabled = !EdgeCollider.enabled;
            anim.SetTrigger("astdes");
            astsound.Play();
            
        }
    }
    public void astdes()
    {
        Destroy(gameObject);
    }
}
