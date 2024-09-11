
using UnityEngine;

public class CryMannager : MonoBehaviour
{
    public static CryMannager Instance;
    private int currentCoins;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentCoins = PlayerPrefs.GetInt("crystal", 0);
    }

    public int GetCoins()
    {
        return currentCoins;
    }

    //public void AddCoins(int amount)
    //{
    //    currentCoins += amount;
    //    PlayerPrefs.SetInt("Coins", currentCoins);
    //    PlayerPrefs.Save();
    //}

    public bool SpendCry(int amount)
    {
        if (currentCoins >= amount)
        {
            currentCoins -= amount;
            PlayerPrefs.SetInt("crystal", currentCoins);
            PlayerPrefs.Save();
            return true;
        }
        else
        {
            return false; // Yeterli para yok
        }
    }
}
