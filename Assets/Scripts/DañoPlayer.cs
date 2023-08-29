using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoPlayer : MonoBehaviour
{
    public Player player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            player.muerte = true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.muerte = true;
        }
    }
}
