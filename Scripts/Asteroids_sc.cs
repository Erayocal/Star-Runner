
using UnityEngine;

public class Asteroids_sc : MonoBehaviour
{
    public static Asteroids_sc main;
    public float sp = 250;
    public float bksp;
    [SerializeField] private GameObject[] astroidPrefabs;
    [SerializeField] private float ýr = 8f;
    public float ck = 0;
    private void Awake()
    {
        main = this;
    }
    private void Start()
    {
        Invoke(nameof(CreateAsteroid), 1f);
        


    }
    private void Update()
    {
        /*if (Map_sc.instance.ck == false)
        {
            CancelInvoke();
            Destroy(gameObject);
        }*/
    }
    public void SetActiveByTag(string tag, bool isActive)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in objectsWithTag)
        {
            obj.SetActive(isActive);
        }
    }
    private void CreateAsteroid()
    {
        if (Map_sc.instance.ck == true)
        {
            GameObject selectedPrefab = astroidPrefabs[Random.Range(0, astroidPrefabs.Length)];
            Vector3 spawnPosition = transform.position;
            Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
            if (Scor_sc.main.scr < 50) { sp = 300f; ýr = 6.5f; bksp = 2f; }
            if (Scor_sc.main.scr >= 200 && Scor_sc.main.scr <400 ) { sp = 350f; ýr = 6f; }
            if (Scor_sc.main.scr >= 500 && Scor_sc.main.scr < 700) { sp = 400f; ýr = 5.5f;bksp = 3f; }
            if (Scor_sc.main.scr >= 700 && Scor_sc.main.scr < 1000) { sp = 450f; ýr = 5.3f; }
            if (Scor_sc.main.scr >= 1000 && Scor_sc.main.scr < 1500) { sp = 500f; ýr = 5f; }
            if (Scor_sc.main.scr >= 2000 ) { sp = 650f;bksp = 3.5f; }
            ck++;
            if (ck == 5f)
            {
                SetActiveByTag("ammo", true);

            }
            else if (ck < 5f)
            {
                SetActiveByTag("ammo", false);
            }
            else if (ck > 5f) { ck = 0f; }

            
        }
        Invoke(nameof(CreateAsteroid), ýr);
    }
   
}
