using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propulsores : MonoBehaviour
{
    public bool blockControl;
    public bool fuerzaDe;
    public bool fuerzaIz;
    public float fuerzaImpulso;

    public Rigidbody rb;
    public ParticleSystem particulaIz, particulaDe;
    public Vector2 dirrecionDe, dirrecionIz;

    public void Start()
    {
        particulaDe.Stop();
        particulaIz.Stop();
    }

    private void Update()
    {
        if (fuerzaDe)
        {
            rb.AddForce(dirrecionDe * fuerzaImpulso * Time.deltaTime);
        }
        if (fuerzaIz)
        {
            rb.AddForce(dirrecionIz * fuerzaImpulso * Time.deltaTime);
        }
        if (!blockControl)
        {
            Controles();
        }
    }

    void Controles()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                
            }
        }
    }

    public void PropulsorDE()
    {
        particulaDe.Stop();
    }
    public void PropulsorIZ()
    {
        particulaIz.Stop();
    }
}
