
using UnityEngine;

public class Torpedo_des : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("asteroid"))
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if(transform.position.y>32f)
        {
            Destroy(gameObject);
        }
    }
}
