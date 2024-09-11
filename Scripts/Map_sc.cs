
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map_sc : MonoBehaviour
{
    public static Map_sc instance;
    public bool ck = true;
    public bool ck2 = true;
    public bool player_movment = true;
    public float sp;
    public GameObject WinUI;
    public GameObject blackhole;
    public GameObject sh_button;
    public GameObject tr_button;
    public GameObject Gamemaneger;
    public GameObject trap;
    public GameObject lasertrap;
    public GameObject ast;
    Scene currentScene;
    string sceneName;
    public float level_ck = 0;


    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        instance = this;
        player_movment = true;
        


    }


    void Update()
    {
        if (Death.Instance.ck==true)
        {
            if(ck2==true)
            transform.position += Vector3.up * sp * Time.deltaTime;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blackhole"))
        {
            if (sceneName == "Gamescane")
            {
                Debug.Log("level 1 oldu");
                PlayerPrefs.SetInt("level1", 1);
                PlayerPrefs.Save();
            }
            if (sceneName == "Game2")
            {
                PlayerPrefs.SetInt("level2", 1);
                PlayerPrefs.Save();
            }

            WinUI.SetActive(true);
            blackhole.SetActive(true);
            ck= false;
            ck2= false;
            player_movment = false;
            sh_button.SetActive(false);
            tr_button.SetActive(false);
            ast.SetActive(false);
            trap.SetActive(false);
            lasertrap.SetActive(false);
            Gamemaneger.SetActive(false);
            EnemyTrap.main.ck2 = false;
            EnemyTrap2_sc.main.ck2 = false;
            
            

        }
        
    }
}
