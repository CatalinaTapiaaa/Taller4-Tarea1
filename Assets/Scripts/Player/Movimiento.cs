using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Header("Componentes")]
    public Rigidbody rb;
    public ParticleSystem particula;
    public ParticleSystem particulaInicial;
    public Rotar rotar;
    public Rotar rotar2;

    [Header("Stats")]
    public float velocidadMovimiento;
    public float fuerzaRotacionZ;
    public float fuerzaImpulsoPlataforma;
    public float delay;
    float tiempo;

    [Space]
    public Vector2 direccionDe;
    public Vector2 direccionIz;

    [Header("Bools")]
    public bool moverseDe;
    public bool moverseIz;
    public bool sinEnergia;
    public bool impulsoPlataforma;

    void Start()
    {
        particula.Stop();
        particulaInicial.Stop();
        impulsoPlataforma = true;
    }

    void Update()
    {
        if (tiempo > delay)
        {
            if (moverseDe)
            {
                transform.Rotate(0, 0, fuerzaRotacionZ * Time.deltaTime);
                rb.AddForce(direccionIz * velocidadMovimiento * Time.deltaTime);
            }
            if (moverseIz)
            {
                transform.Rotate(0, 0, -fuerzaRotacionZ * Time.deltaTime);
                rb.AddForce(direccionDe * velocidadMovimiento * Time.deltaTime);
            }
            if (!impulsoPlataforma)
            {
                rotar.encender = true;
                rotar2.encender = true;
            }
            particulaInicial.Stop();
        }
        if (sinEnergia)
        {
            rotar.encender = false;
            rotar2.encender = false;
            PropulsorDeEnd();
            PropulsorIzEnd();
        }

        tiempo += Time.deltaTime;
    }

    void Salto()
    {
        particulaInicial.Play();
        rb.AddForce(Vector3.up * fuerzaImpulsoPlataforma, ForceMode.Impulse);
        impulsoPlataforma = false;
        tiempo = 0;
    }


    //Botones Comienzo
    public void PropulsorDe()
    {
        moverseDe = true;
        particula.Play();

        if (impulsoPlataforma)
        {
            Salto();
        }
    }

    public void PropulsorIz()
    {
        moverseIz = true;
        particula.Play();

        if (impulsoPlataforma)
        {
            Salto();
        }
    }

    //Botones Fin
    public void PropulsorDeEnd()
    {
        moverseDe = false;
        particula.Stop();
    }
    public void PropulsorIzEnd()
    {
        moverseIz = false;
        particula.Stop();
    }
}
