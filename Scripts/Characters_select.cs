

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Characters_select : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;
    public GameObject buybutton;
    public GameObject selectbutton;
    public int[] characterPrices;
    public Text cry_text;
    public Text Sh_text;
    
    
    private void Start()
    {
        UpdateButtons();
        cry_text.text =" "+ PlayerPrefs.GetInt("crystal").ToString();
    }
    
    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
        UpdateButtons();
    }
    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
        UpdateButtons();
        


    }
    private void UpdateButtons()
    {
        string characterName = characters[selectedCharacter].name;
        if (IsItemPurchased(characterName))
        {
            buybutton.SetActive(false);
            selectbutton.SetActive(true);
        }
        else
        {
            buybutton.SetActive(true);
            selectbutton.SetActive(false);
        }
    }
    
   
    public void SelectCh()
    {
        string characterName = characters[selectedCharacter].name;
        if (IsItemPurchased(characterName))
        {
            PlayerPrefs.SetInt("selectedCh", selectedCharacter);
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        else { Debug.Log("Satýn alýnmadý"); }
    }

    public void Buych()
    {
        string characterName = characters[selectedCharacter].name;
        int price = characterPrices[selectedCharacter];

        if (CryMannager.Instance.SpendCry(price))
        {
            PlayerPrefs.SetInt(characterName, 1);
            PlayerPrefs.Save();
            UpdateButtons();
        }
        cry_text.text =" "+ PlayerPrefs.GetInt("crystal").ToString();
    }

   public bool IsItemPurchased(string ch1)
    { 
        return PlayerPrefs.GetInt(ch1, 0) == 1;
        
    }
    private void Update()
    {
        cry_text.text = " " + PlayerPrefs.GetInt("crystal").ToString();
        if (selectedCharacter == 0) { Sh_text.text = "3"; }
        if (selectedCharacter == 1) { Sh_text.text = "5"; }
        if (selectedCharacter == 2) { Sh_text.text = "10"; }
        if (selectedCharacter == 3) { Sh_text.text = "15"; }
        if (selectedCharacter == 4) { Sh_text.text = "20"; }
    }
    public void ResetPurchases()
    {
        foreach (GameObject character in characters)
        {
            string characterName = character.name;
            PlayerPrefs.DeleteKey(characterName);
        }
        PlayerPrefs.Save();
        UpdateButtons();
    }

}
