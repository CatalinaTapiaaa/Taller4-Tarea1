using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaquePlayer : MonoBehaviour
{
    [Header("Stats")]
    public float rayDistancia;

    void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.up, out hit, rayDistancia))
        {
            if (hit.transform.tag == "Enemy")
            {
                hit.transform.gameObject.GetComponent<Enemy>().muerte = true;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.up * rayDistancia);
    }
}
