
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Shop : MonoBehaviour
{
    public void Shop_menu()
    {
        SceneManager.LoadScene("Shop_menu");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
    public void Nextlevel()
    {
        SceneManager.LoadScene("Level_menu");
    }
}
