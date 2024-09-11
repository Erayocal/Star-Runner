using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrap2_sc : MonoBehaviour
{
    static public EnemyTrap2_sc main;
    public GameObject Enemy2;
    public float sp;
    public GameObject Laser;
    public Transform firePoint;
    public float bulletSpeed;
    private bool ck = false;
    [SerializeField] private AudioSource lasersound;
    public bool ck2=true;
    private
    void Start()
    {
        main = this;
        InvokeRepeating(nameof(CreateEnemy), 60f, 60f);
        Enemy2.SetActive(false);
    }




    public void CreateEnemy()
    {
        Enemy2.SetActive(true);
        Map_sc.instance.ck = false;
        ck = false;

    }
    private void Update()
    {
        if (ck2 == false) { CancelInvoke(); }
        if (Enemy2.transform.position.y > 20f && ck == false)
        {
            transform.position += Vector3.down * sp * Time.deltaTime;

        }
        else if (Enemy2.transform.position.y < 20f)
        {
            CreateLaser();
        }
        if (ck == true)
        {
            Enemy2.transform.position += Vector3.up * sp * Time.deltaTime;
            if (Enemy2.transform.position.y >= 40f)
            {
                Map_sc.instance.ck = true;
                gameObject.SetActive(false);
            }
        }

    }
    private void CreateLaser()
    {
        GameObject bullet = Instantiate(Laser, firePoint.position, firePoint.rotation);
        Vector2 direction = Vector2.down;
        bullet.GetComponent<Laser_move>().direction = direction;
        bullet.GetComponent<Laser_move>().speed = bulletSpeed;
        ck = true;
        lasersound.Play();
    }
}
