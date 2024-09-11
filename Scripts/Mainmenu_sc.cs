

using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu_sc : MonoBehaviour
{
    public static Mainmenu_sc main;
    public GameObject player;
    public bool ck = false;
    private bool ck2= false;
   

    private void Awake()
    {
        main = this;
    }
    
    public void StartGame()
    {
        ck= true;
    }

    
    void Update()
    {
        if (player.transform.position.y < 7f && ck == true)
        {
            player.transform.position += new Vector3(0, 8f * Time.deltaTime, 0);
            
            if (player.transform.position.y > 7f) { ck2 = true; }

        }
        if (ck2 == true)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }


}
