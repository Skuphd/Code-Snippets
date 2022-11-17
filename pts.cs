using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pts : MonoBehaviour
{
    public int points = 10;

    public void setPoints(int j){ points += j; }
    public int getPoints(){ return points; }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "10 pts")
            setPoints(10);
        if (collision.tag == "5 pts")
            setPoints(5);
        if (collision.tag == "1 pts")
            setPoints(1);
        if (collision.tag == "0 pts")
            setPoints(0);
    }
}
