using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Shield_open : MonoBehaviour
{
    static public Shield_open main;
    public GameObject Shield;
    public GameObject Shield2;
    public GameObject Shield3;
    public GameObject Shield4;
    public GameObject Shield5;
    public GameObject Text_time;
    public GameObject buttonText;
    //public Button Torpido;
    //public bool ck = true;
    public Text sh_time_text;
    public Text sh_button_text;
    private float sh_text1 = 3;
    private float sh_text2 = 5;
    private float sh_text3 = 10;
    private float sh_text4 = 15;
    private float sh_text5 = 20;
    private float sh_button = 40;
    int selectedCharacter;
    //public GameObject Shield_button;
    //private bool ck;
    public Button Shield_button;
    [SerializeField] private AudioSource shieldsound;

    void Start()
    {
        main= this;
        Shield_button.onClick.AddListener(shield_cl);
        selectedCharacter = PlayerPrefs.GetInt("selectedCh");
        //InvokeRepeating(nameof(), 1f,5f);
    }
   
    public void shield_cl()
    {
        //ck = false;
        Shield_button.interactable = false;
        //Torpido.interactable = false;
        
        StartCoroutine(sh_button_open(40f));
        StartCoroutine(sh_stay_open(3f));
        StartCoroutine(sh_stay_open2(5f));
        StartCoroutine(sh_stay_open3(10f));
        StartCoroutine(sh_stay_open4(15f));
        StartCoroutine(sh_stay_open5(20f));
        shieldsound.Play();
        Shield.SetActive(true);
        Shield2.SetActive(true);
        Shield3.SetActive(true);
        Shield4.SetActive(true);
        Shield5.SetActive(true);
        InvokeRepeating(nameof(sh_time), 0f, 1f);
        InvokeRepeating(nameof(sh_buttontime), 0f, 1f);
        Text_time.SetActive(true);
        buttonText.SetActive(true);
        
    }
    private void sh_buttontime()
    {
        sh_button_text.text = " " + sh_button;
        sh_button -= 1;
    }
    IEnumerator sh_button_open(float delay)
    {
        yield return new WaitForSeconds(delay);
        Shield_button.interactable = true;
        sh_button = 40;
        buttonText.SetActive(false);
        CancelInvoke(nameof(sh_buttontime));
        
    }
    
    IEnumerator sh_stay_open(float delay)
    {
        yield return new WaitForSeconds(delay);
        Shield.SetActive(false);
        
        if (selectedCharacter == 0)
        {
            //Torpido.interactable = true;
            //ck = true;
            sh_text1 = 3f;
            CancelInvoke(nameof(sh_time));
            Text_time.SetActive(false);
        }
    }

    IEnumerator sh_stay_open2(float delay)
    {
        yield return new WaitForSeconds(delay);
        Shield2.SetActive(false);
        if (selectedCharacter == 1)
        {
            //Torpido.interactable = true;
            sh_text2 = 5f;
            CancelInvoke(nameof(sh_time));
            Text_time.SetActive(false);
        }
    }
    IEnumerator sh_stay_open3(float delay)
    {
        yield return new WaitForSeconds(delay);
        Shield3.SetActive(false);
        if (selectedCharacter == 2)
        {
            //Torpido.interactable = true;
            sh_text3 = 10f;
            CancelInvoke(nameof(sh_time));
            Text_time.SetActive(false);
        }
    }
    IEnumerator sh_stay_open4(float delay)
    {
        yield return new WaitForSeconds(delay);
        Shield4.SetActive(false);
        if (selectedCharacter == 3)
        {
            //Torpido.interactable = true;
            sh_text4 = 15f;
            CancelInvoke(nameof(sh_time));
            Text_time.SetActive(false);
        }
    }
    IEnumerator sh_stay_open5(float delay)
    {
        yield return new WaitForSeconds(delay);
        Shield5.SetActive(false);
        
        if (selectedCharacter == 4)
        {
            //Torpido.interactable = true;
            //ck = true;
            sh_text5 = 20f;
            CancelInvoke(nameof(sh_time));
            Text_time.SetActive(false);
        }
    }
    private void sh_time()
    {
        if (selectedCharacter == 0)
        {
            sh_time_text.text = " " + sh_text1;
            sh_text1 -= 1;
        }
        if (selectedCharacter == 1)
        {
            sh_time_text.text = " " + sh_text2;
            sh_text2 -= 1;
        }
        if (selectedCharacter == 2)
        {
            sh_time_text.text = " " + sh_text3;
            sh_text3 -= 1;
        }
        if (selectedCharacter == 3)
        {
            sh_time_text.text = " " + sh_text4;
            sh_text4 -= 1;
        }
        if (selectedCharacter == 4)
        {
            sh_time_text.text = " " + sh_text5;
            sh_text5 -= 1;
        }
        
    }

}
