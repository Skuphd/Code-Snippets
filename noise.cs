using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noise : MonoBehaviour
{
    public AudioSource c1;
    public AudioSource c2;
    int i;

    void Start()
    {
        c1 = GetComponent<AudioSource>();
        c2 = GetComponent<AudioSource>();
    }

    void selectAudio()
    {
        i = Random.Range(0, 1);
        if (i == 0)
            c1.Play();
        if (i == 1)
            c2.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "packinkoPole")
            selectAudio();
    }
}
