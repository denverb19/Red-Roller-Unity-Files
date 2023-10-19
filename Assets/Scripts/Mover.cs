using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float yValue = 0.00f;
    [SerializeField] float moveSpeed = 25.0f;

    void Start()
    {
        //transform.Translate(1, 0, 0);
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use arrow keys to move player");
        Debug.Log("Don't hit the obstacles");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
