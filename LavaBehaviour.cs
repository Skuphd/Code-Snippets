using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBehaviour : MonoBehaviour
{
    public Transform pStart;
    public GameObject player;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Instantiate(player, pStart);
            Debug.Log("Player Fell in the Lava");
        }    
    }
}
