
using UnityEngine;


public class Trap_sc : MonoBehaviour
{
    public static Trap_sc main;

    [SerializeField] private GameObject[] TrapPrefabs;
    public Transform Player;
    public float lastXPosition;
    public GameObject Laser;

    private void OnEnable()
    {
        InvokeRepeating(nameof(CreateTrap), 35f, 35f);
    }
    private void Update()
    {
        /*if (Map_sc.instance.ck == false)
        {
            CancelInvoke();
            Destroy(gameObject);
            
        }*/
        
    }
    void Start()
    {
        main = this;
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        lastXPosition = Player.position.x;


    }
    private void CreateTrap()
    {
        if (Map_sc.instance.ck == true)
        {
            lastXPosition = Player.position.x;
            GameObject selectedPrefab = TrapPrefabs[Random.Range(0, TrapPrefabs.Length)];

            Instantiate(selectedPrefab, transform.position, Quaternion.identity);
        }
    }
    
}
