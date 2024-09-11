using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_menu : MonoBehaviour
{
    public Button level2;
    public Button level3;
    private float level_ck;
    private float level_ck2;
    private void Start()
    {
        level2.interactable = false;
        level3.interactable = false;
        
        
        //PlayerPrefs.DeleteKey("Finger");


    }
    private void Update()
    {
        level_ck = PlayerPrefs.GetInt("level1");
        if (level_ck == 1)
        {
            Debug.Log("level 2 açýldý");
            level2.interactable = true;
        }
        level_ck2 = PlayerPrefs.GetInt("level2");
        if (level_ck2 == 1)
        {
            level3.interactable = true;
        }
    }
    public void Level1()
    {
        SceneManager.LoadScene("Gamescane");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Game3");
    }
    

    
}
