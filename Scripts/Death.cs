
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public static Death Instance;
    [SerializeField] private Text topscore;
    public bool ck=true;
    public GameObject resb;
    public GameObject topscr;
    public GameObject shop_button;
    public GameObject menu_button;
    public GameObject scoremaneger;
    public GameObject ast;
    //public GameObject joystc;
    public GameObject scr;
    public GameObject Topscr_main;
    public GameObject Ship2Engine;
    public GameObject sh_button;
    public GameObject tr_button;
    private Animator anim;
    public GameObject Gamemaneger;
    private BoxCollider2D boxCollider;
    [SerializeField] private AudioSource deathsound;
    private int ads_count;
    private void Start()
    {
        Instance = this;
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        ads_count= 0;

    }
    private void Update()
    {
        ads_count = PlayerPrefs.GetInt("ads_count");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("asteroid"))
        {
            Die();
        }
    }
    
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("asteroid"))
        {
            Die();
        }
    }*/

    private void Die()
    {
        topscore.text = "Top score: " + PlayerPrefs.GetInt("HighScore").ToString();
        anim.SetTrigger("Death");
        boxCollider.enabled = !boxCollider.enabled;
        deathsound.Play();
        
        
    }
    public void Playerdie() {
        
        
        ck= false;
        resb.SetActive(true);
        topscr.SetActive(true);
        shop_button.SetActive(true);
        menu_button.SetActive(true);
        ast.SetActive(false);
        scr.SetActive(false);
        Topscr_main.SetActive(false);
        //joystc.SetActive(false);
        Gamemaneger.SetActive(false);
        scoremaneger.SetActive(false);
        gameObject.SetActive(false);
        sh_button.SetActive(false);
        tr_button.SetActive(false);
        //Ads_Maneger_death.main.ShowAds();
        
        ads_count++;
        PlayerPrefs.SetInt("ads_count", ads_count);
        
        if (PlayerPrefs.GetInt("ads_count") == 3)
        {
            ads_count = 0;
            PlayerPrefs.SetInt("ads_count", ads_count);
            Ads_Maneger_death.main.ShowInterstitialAd();
        }
        PlayerPrefs.Save();
    }
    public void Ship2Eng() { Ship2Engine.SetActive(false); }
}
