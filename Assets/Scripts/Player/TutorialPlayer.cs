using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPlayer : MonoBehaviour
{
    public Image barraDe;
    public Image barraIz;

    public float rellenarBarra;
    public float fuerzaRotacionZ;
    public bool moverseDe;
    public bool moverseIz;

    float cargaMax = 100;
    float tiempo1, tiempo2;

    private void Update()
    {
        if (moverseDe)
        {
            transform.Rotate(0, 0, fuerzaRotacionZ * Time.deltaTime);
            tiempo1 += rellenarBarra * Time.deltaTime;
        }
        if (moverseIz)
        {
            tiempo2 += rellenarBarra * Time.deltaTime;
            transform.Rotate(0, 0, -fuerzaRotacionZ * Time.deltaTime);
        }

        barraDe.fillAmount = tiempo1 / cargaMax;
        barraIz.fillAmount = tiempo2 / cargaMax;
    }
    public void PropulsorDe()
    {

    }
    public void PropulsorIz()
    {

    }

    public void PropulsorDeEnd()
    {

    }
    public void PropulsorIzEnd()
    {

    }
}
