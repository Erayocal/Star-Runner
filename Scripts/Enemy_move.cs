
using UnityEngine;

public class Enemy_move : MonoBehaviour
{
    
    public float Enemysp;
    public GameObject Laser;
    public Transform firePoint;
    public float bulletSpeed;
    private float count = 0;
    private bool ck = true;
    [SerializeField] private AudioSource lasersound;

    private void Update()
    {
        if (ck == true)
        {
            if (transform.position.y > 25f)
            {
                Vector3 targetPosition = new Vector3(Laser_sc.main.lastXPosition, transform.position.x, transform.position.z);
                transform.position = new Vector3(Laser_sc.main.lastXPosition, transform.position.y - (Enemysp * Time.deltaTime), transform.position.z);
            }
            else if (transform.position.y <= 25f)
            {
                if (count == 0) { Cretalaser(); }

            }
        }else
        {
            transform.Translate(Vector2.up * Enemysp * Time.deltaTime);
            if (transform.position.y > 30f) { Destroy(gameObject); }
        }
        
    }
    private void Cretalaser()
    {
        
        GameObject bullet = Instantiate(Laser, firePoint.position, firePoint.rotation);
        Vector2 direction = Vector2.down;
        bullet.GetComponent<Laser_move>().direction = direction;
        bullet.GetComponent<Laser_move>().speed = bulletSpeed;
        lasersound.Play();
        count++;
        ck= false;
    }
   
   
}
