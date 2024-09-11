
using UnityEngine;


public class Start_sc : MonoBehaviour
{
    static public Start_sc instance;
    public GameObject player;
    private bool ck = true;
    public bool ck2 = false;
    private float Fingerck = 0;
    public GameObject ast;
    public GameObject image;
    public GameObject cry;
    public GameObject joystc;
    public GameObject score;
    public GameObject Topscr_main;
    public GameObject Gamemaneger;
    public GameObject Laser_trap;
    public GameObject Finger;

    private void Start()
    {
        instance = this;
        if(PlayerPrefs.GetInt("Finger", 0) == 1)
        {
            Finger.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        if (GameObject.FindWithTag("Player").transform.position.y < 5f && ck == true)
        {
            GameObject.FindWithTag("Player").transform.position += new Vector3(0, 8f * Time.deltaTime, 0);
            if (GameObject.FindWithTag("Player").transform.position.y > 5f) { ck2 = true; }
            
        }

        if (ck2 == true) //&& PlayerPrefs.GetInt("Finger", 0) == 1
        {
            ast.SetActive(true);
            score.SetActive(true);
            Topscr_main.SetActive(true);
            cry.SetActive(true);
            image.SetActive(true);
            Gamemaneger.SetActive(true);
            Laser_trap.SetActive(true);
            ck = false;
            ck2 = false;
        }
        
            
            

        
        if (Fingerck == PlayerPrefs.GetInt("Finger", 0))
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    Finger.SetActive(false);
                    PlayerPrefs.SetInt("Finger", 1);
                }
            }
        }
    }
}
