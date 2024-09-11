
using UnityEngine;
using UnityEngine.UI;


public class Crystal_collect : MonoBehaviour
{
    public static Crystal_collect Instance;
    public int cry;
    private int currentCoins;
    private void Awake()
    {
        Instance= this;
       
    }
    [SerializeField] private Text crystal_text;
    [SerializeField] private AudioSource cryaudioSource;
    
    public int GetCoins()
    {
        return cry;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("crystal"))
        {
            Destroy(collision.gameObject);
            cry++;
            PlayerPrefs.SetInt("crystal", cry);
            
            cryaudioSource.Play();

        }
    }
    private void Update()
    {
        crystal_text.text = "" + PlayerPrefs.GetInt("crystal").ToString();
        cry = PlayerPrefs.GetInt("crystal");
    }

   
}
