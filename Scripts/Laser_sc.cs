
using UnityEngine;

public class Laser_sc : MonoBehaviour
{
    public static Laser_sc main;

    
    public Transform Player;
    public float lastXPosition;
    public float lastXPositionEnemy;
    //public GameObject Laser;
    public GameObject Enemy;
    
    private void OnEnable()
    {
        main=this;
        InvokeRepeating(nameof(CreateTrap2), 40f, 40f);
    }
    void Start()
    {
        main = this;
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        
        lastXPosition = Player.position.x;
    }
    private void Update()
    {
        /*if (Map_sc.instance.ck == false)
        {
            CancelInvoke();
            Destroy(gameObject);
            
        }*/
    }
    private void CreateTrap2()
    {
        if (Map_sc.instance.ck == true)
        {
            lastXPosition = Player.position.x;
            Instantiate(Enemy, transform.position, Quaternion.identity);
        }
    }
    

}
