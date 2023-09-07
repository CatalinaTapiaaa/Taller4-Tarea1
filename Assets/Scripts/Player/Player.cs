using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool muerte;
    [Space]
    public Reiniciar reiniciar;

    void Update()
    {
        if (muerte)
        {
            Destroy(gameObject);
            reiniciar.reiniciar = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            muerte = true;
        }
    }

}
