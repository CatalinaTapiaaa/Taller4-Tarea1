using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaDe : MonoBehaviour
{
    public float tiempo;
    [Header("Componentes")]
    public Player player;
    public Movimiento movimiento;
    [Space]
    public ParticleSystem par;
    public GameObject panelSatisfaccionInstantanea;
    public GameObject x;

    [Header("Bools")]
    public bool camaraLenta;
    public bool playerTrigger, playerCollision;
    float timer;

    private void Start()
    {
        par.Stop();
    }
    void Update()
    {       
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemy");
        timer += Time.deltaTime;
        if (timer >= tiempo)
        {
            if (enemigos.Length == 0)
            {
                x.SetActive(false);
                gameObject.tag = "Plataforma";

                if (playerTrigger)
                {
                    camaraLenta = true;
                    par.Play();
                }
                if (playerCollision)
                {
                    movimiento.sinEnergia = true;
                    panelSatisfaccionInstantanea.SetActive(true);
                }
            }
        }       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerTrigger = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerTrigger = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerCollision = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerCollision = false;
        }
    }
}
