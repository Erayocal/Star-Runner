
using UnityEngine;

public class Trap_move : MonoBehaviour
{
    public float sp;
    void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3(Trap_sc.main.lastXPosition, transform.position.x , transform.position.z);
        transform.position = new Vector3(Trap_sc.main.lastXPosition, transform.position.y - (sp * Time.deltaTime), transform.position.z);

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
