
using UnityEngine;

public class Ammo_sc : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (transform.position.y < -11f) {Destroy(gameObject); }
    }
}
