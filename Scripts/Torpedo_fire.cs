
using UnityEngine;
using UnityEngine.UI;

public class Torpedo_fire : MonoBehaviour
{
   
    public GameObject Torpedo;
    public Text ammo_tx;
    public Transform firePoint;
    public float bulletSpeed = 10f;
    public Button fireButton;
    public float ammo_nm;
    [SerializeField] private AudioSource torpedosound;
    void Start()
    {
        fireButton.onClick.AddListener(CretaTorpedo);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ammo"))
        {
            ammo_nm++;
        }
    }
    private void Update()
    {
        if (ammo_nm <= 0)
        {
            fireButton.interactable = false;
        }
        else
        {
                fireButton.interactable = true;
        }
        /*if(Shield_open.main.ck==true && ammo_nm>0)
        { fireButton.interactable = true; }*/
        /*if(Shield_open.main.Torpido.interactable==true && ammo_nm>0)
        {
            fireButton.interactable = true;
        }*/
        ammo_tx.text=" "+ammo_nm.ToString();
    }
    private void CretaTorpedo()
    {

        GameObject torpedo = Instantiate(Torpedo, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = torpedo.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.up * bulletSpeed;
            torpedosound.Play();
        }
        ammo_nm -= 1;
    }
}
