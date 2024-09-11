
using UnityEngine;

public class Background_an : MonoBehaviour
{

    /*[SerializeField] private float speed;
    
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0f, Time.deltaTime * speed);
    }*/

    public float Speed = 2;

    private float offset;
    private Material mat;



    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }


    void Update()
    {
        if (Start_sc.instance.ck2 == true && PlayerPrefs.GetInt("Finger", 0) == 1)
        {
            if (Scor_sc.main.scr >= 400 && Scor_sc.main.scr < 1000) { Speed = 3f; }
            if (Scor_sc.main.scr >= 1000) { Speed = 3.5f; }
        }
        offset += (Time.deltaTime * Speed) / 10;
        mat.SetTextureOffset("_MainTex", new Vector2(0,offset));

        
    }
}
