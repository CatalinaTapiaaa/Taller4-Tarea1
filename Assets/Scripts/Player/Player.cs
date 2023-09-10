using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool muerte;
    [Space]
    public Reiniciar reiniciar;
    public GameObject explocion;
    public Transform posicionExplocion;

    void Update()
    {
        if (muerte)
        {
            Instantiate(explocion, posicionExplocion.position, Quaternion.identity);
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
        if (collision.gameObject.CompareTag("Enemy"))
        {
            muerte = true;
        }
    }

}
