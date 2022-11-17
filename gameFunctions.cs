using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameFunctions : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject sign;

    public void pachinkoStart() {
        Destroy(sign);
        for(int i = 10; i > 0; i--)
            Instantiate(ballPrefab, new Vector3(Random.Range(-9.5f,9.5f),11,0), Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            pachinkoStart();
    }
}
