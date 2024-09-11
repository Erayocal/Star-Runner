
using UnityEngine;

public class Blackhole_sc : MonoBehaviour
{
    private bool ck = true;
    private float sp = 2f;
    [SerializeField] private float rs;
    void FixedUpdate()
    {
        if(ck==true )
        //float downEdge = Camera.main.ScreenToViewportPoint(Vector3.zero).y - 9f;
        transform.position += Vector3.down * sp * Time.deltaTime;
        transform.Rotate(0, 0, rs * Time.deltaTime);
        //if (transform.position.y < downEdge) { Destroy(gameObject); }
        if (transform.position.y <= 12.5f) { ck = false; }

    }

    
}
