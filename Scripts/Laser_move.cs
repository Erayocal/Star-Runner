
using UnityEngine;

public class Laser_move : MonoBehaviour
{
    public float speed;
    public Vector2 direction;
    void FixedUpdate()
    {
        

        transform.Translate(direction * speed * Time.deltaTime);

        float downEdge = Camera.main.ScreenToViewportPoint(Vector3.zero).y - 9f;
        if (transform.position.y < downEdge) { Destroy(gameObject); }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("shield"))
        {
            Destroy(gameObject);
        }
    }
}
