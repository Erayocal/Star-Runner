using UnityEngine.UI;
using UnityEngine;

public class Audio_sc : MonoBehaviour
{
    public GameObject sound;
    public Button Audiobutton;
    private bool isSoundOn;
    private Color originalColor;
    private Color transparentColor;
    private void Start()
    {
        Audiobutton = GetComponent<Button>();

        originalColor = Audiobutton.colors.normalColor;

        transparentColor= new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);

        if (PlayerPrefs.HasKey("SoundState"))
        {
            isSoundOn = PlayerPrefs.GetInt("SoundState") == 1;
        }
        else
        {
            isSoundOn = true;
        }
        sound.SetActive(isSoundOn);
        UpdateButtonVisual();

        Audiobutton.onClick.AddListener(ToggleSound);
    }
    public void ToggleSound()
    {
        isSoundOn = !isSoundOn;

       
        PlayerPrefs.SetInt("SoundState", isSoundOn ? 1 : 0);
        PlayerPrefs.Save();

        sound.SetActive(isSoundOn);
        UpdateButtonVisual();
    }

    private void UpdateButtonVisual()
    {
        ColorBlock cb = Audiobutton.colors;
        cb.normalColor = isSoundOn ? originalColor : transparentColor;
        Audiobutton.colors = cb;
    }
    
}
