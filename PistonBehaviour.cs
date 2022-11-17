using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonBehaviour : MonoBehaviour
{
    public GameObject piston;
    public float maxDistance;
    public float speed = 2;
    private bool move = true;

    public void pForward()
    {
        piston.transform.Translate(new Vector3(maxDistance, 0f, 0f) * speed * Time.deltaTime);
    }
    public void pReverse()
    {
        piston.transform.Translate(new Vector3(-maxDistance, 0f, 0f) * speed * Time.deltaTime);
    }
    void Update()
    {
        if (piston.transform.localPosition.x <= maxDistance && move == true)
        {
            pForward();
            if (piston.transform.localPosition.x >= maxDistance)
            {
                move = false;
                Debug.Log("Reverse");
            }
        }
        if(piston.transform.localPosition.x >= 0f && move == false)
        {
            pReverse(); 
            if (piston.transform.localPosition.x <= 0f)
            {
                move = true;
                Debug.Log("Forward");
            }
        }
    }
}
