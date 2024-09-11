
using UnityEngine;

public class prefebs_move : MonoBehaviour
{


    private float sp = 2.5f;
    void FixedUpdate()
    {
        float downEdge = Camera.main.ScreenToViewportPoint(Vector3.zero).y - 9f;
        transform.position += Vector3.down * sp * Time.deltaTime;
        if (transform.position.y < downEdge) { Destroy(gameObject); }
    }
}
