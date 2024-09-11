
using UnityEngine;

public class Load_ch : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    //public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public GameObject Player5;
    public GameObject Player6;
    public Transform spawnPoint;
    int selectedCharacter;
    private void Start()
    {
        selectedCharacter = PlayerPrefs.GetInt("selectedCh");
        chSelect();
        //GameObject prefab = characterPrefabs[selectedCharacter];
        //GameObject clone= Instantiate(prefab,spawnPoint.position,Quaternion.identity);
    }
    private void chSelect()
    {
        if (selectedCharacter == 0)
        {
            Player2.SetActive(true);
        }
        if (selectedCharacter == 1)
        {
            Player3.SetActive(true);
        }
        if (selectedCharacter == 2)
        {
            Player4.SetActive(true);
        }
        if (selectedCharacter == 3)
        {
            Player5.SetActive(true);
        }
        if (selectedCharacter == 4)
        {
            Player6.SetActive(true);
        }
        

    }
}
