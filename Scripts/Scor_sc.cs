
using UnityEngine;
using UnityEngine.UI;

public class Scor_sc : MonoBehaviour
{
    public static Scor_sc main;
    public GameObject Traps;
    public GameObject ast;
    //public GameObject blackhole;
    public bool ck = true;

    [SerializeField] private Text score;
    [SerializeField] private Text Topscr_main;
    


    public int scr = 0;
    //private float scoreIncreaseRate = 25f;
    private void Awake()
    {
        main = this;
    }

    private void Start()
    {
        scr = 0;
        UpdateScoreText();
        StartScoreIncrease();
        Topscr_main.text= "High score :" + PlayerPrefs.GetInt("HighScore").ToString();
    }
    void FixedUpdate()
    {
        if (scr == 800)
        {
            Traps.SetActive(true);
        }
        if (scr > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scr);
        }
        /* if(scr==5000)
        {
            ck=false;
            ast.SetActive(false);
            blackhole.SetActive(true);
        }*/
    }
    void UpdateScoreText()
    {
        if (ck == true)
        {
            score.text = "Score: " + scr.ToString();
        }
    }

    void StartScoreIncrease()
    {
        
        InvokeRepeating(nameof(IncreaseScore), 0.1f, 0.1f);
    }

    void IncreaseScore()
    {
        if (Map_sc.instance.ck == true)
        {
            scr += 1;
            //CheckScoreAndUpdate();
            UpdateScoreText();
        }
    }
    
}
