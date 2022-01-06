using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] public GameObject[] waypoints;
    private int current = 0;

    [SerializeField] public bool playerOnPoint = false;

    [SerializeField] private float speed = 2;

    private void Update()
    {
        // if (!playerOnPoint)
        // {
        //     player.transform.position = Vector3.MoveTowards(player.transform.position, waypoints[0].transform.position, Time.deltaTime * speed);
        // }
    }
}
