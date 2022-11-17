using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public GameObject pStart;
    public GameObject player;
    public GameObject point;
    public int scenenum;

    void Start()
    {
        point = GameObject.FindGameObjectWithTag("Point");
        pStart = GameObject.Find("StartArea");
        Instantiate(player, pStart.transform);
    }

    private void Update()
    {
        if (point == null)
            SceneManager.LoadScene(scenenum);
    }
}
