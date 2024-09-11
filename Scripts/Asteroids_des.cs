
using UnityEngine;

public class Asteroids_des : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float rs;

    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float downEdge = Camera.main.ScreenToViewportPoint(Vector3.zero).y - 9f;
        //transform.position += Vector3.down * Asteroids_sc.main.sp * Time.deltaTime;
        //rb.velocity = transform.forward * Asteroids_sc.main.sp * Time.deltaTime;
        rb.velocity = new Vector2(rb.velocity.x, -Asteroids_sc.main.sp * Time.deltaTime);
        transform.Rotate(0, 0, rs * Time.deltaTime);
        if (transform.position.y < downEdge)
        {
            Destroy(gameObject);
        }
    }
}
