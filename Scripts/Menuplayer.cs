
using UnityEngine;


public class Menuplayer : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Mainmenu_sc.main.ck == true) { anim.SetTrigger("flysp"); }
    }
}
