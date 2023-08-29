using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemy : MonoBehaviour
{
    public Transform[] pivotEnemy;
    public GameObject enemy;
    public int cantidadMin, cantidadMax;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        
    }

    private void Spawn()
    {
        int cantidadEnemy = Random.Range(cantidadMin, cantidadMax);

        for (int i = 0; i < cantidadEnemy; i++)
        {
            int pívotAleatorio = Random.Range(0, pivotEnemy.Length);

            Instantiate(enemy, pivotEnemy[pívotAleatorio].position, Quaternion.identity);
        }
    }
}
