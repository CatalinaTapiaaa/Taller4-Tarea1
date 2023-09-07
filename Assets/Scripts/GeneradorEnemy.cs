using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemy : MonoBehaviour
{
    public Transform[] pivotEnemy;
    public GameObject[] enemyOrTrampa;
    public GameObject botones;
    public bool reiniciar;
    public float tiempoAni;
    float tiempo;
    int current;

    void Start()
    {
        reiniciar = true;
    }

    void Update()
    {
        if (reiniciar)
        {
            tiempo += Time.deltaTime;
            botones.SetActive(false);

            if (tiempo >= tiempoAni)
            {
                int aleatorio = Random.Range(0, enemyOrTrampa.Length);
                Instantiate(enemyOrTrampa[aleatorio], pivotEnemy[current].position, Quaternion.identity);
                tiempo = 0;
                current++;
            }
            if (current == 4)
            {
                reiniciar = false;
            }
        }
        else
        {
            botones.SetActive(true);
        }
    }
}
