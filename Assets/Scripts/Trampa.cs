using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public Animator ani;

    void Start()
    {
        StartCoroutine(Animacion());
    }

    private IEnumerator Animacion()
    {
        ani.SetBool("Move", true);
        yield return new WaitForSeconds(0.40f);
        ani.SetBool("Move", false);
    }
}
