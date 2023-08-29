using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    [Header("Componentes")]
    public Rigidbody rb;
    public ParticleSystem particulaIz, particulaDe;

    [Header("Stats")]
    public float fuerzaImpulso;
    public float fuerzaRotacion;
    public Vector2 direccionDe, direccionIz;

    public bool fuerzaDe, fuerzaIz, sinEnergia;


    void Start()
    {
        particulaIz.Stop();
        particulaDe.Stop();
    }

    void Update()
    {
        if (fuerzaDe)
        {
            transform.Rotate(0, 0, fuerzaRotacion * Time.deltaTime);
            rb.AddForce(direccionIz * fuerzaImpulso * Time.deltaTime);
        }

        if (fuerzaIz)
        {
            transform.Rotate(0, 0, -fuerzaRotacion * Time.deltaTime);
            rb.AddForce(direccionDe * fuerzaImpulso * Time.deltaTime);
        }

        if (sinEnergia)
        {
            PropulsorDeEnd();
            PropulsorIzEnd();
        }
    }

    public void PropulsorDe()
    {
        fuerzaDe = true;
        particulaDe.Play();
    }

    public void PropulsorDeEnd()
    {
        fuerzaDe = false;
        particulaDe.Stop();
    }

    public void PropulsorIz()
    {
        fuerzaIz = true;
        particulaIz.Play();
    }

    public void PropulsorIzEnd()
    {
        fuerzaIz = false;
        particulaIz.Stop();
    }
}
