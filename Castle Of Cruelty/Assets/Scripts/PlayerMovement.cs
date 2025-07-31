using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 25f;
    private bool isFacingRight;


    private Vector2 move; //Direction we're moving in the X axis and Y axis, set as coordinate
    private Rigidbody2D rb2d; //Reference to the Player's RigidBody2D (Movement and Physics)
    private GameManager gm; //Reference to the GameManager

    private SpriteRenderer PlayerSprite;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        PlayerSprite = GetComponent<SpriteRenderer>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame


    void Update()
    {
        //If level is not complete, player is able to move
        //When the level is complete, the player is not able to move

        if (gm.levelComplete == false)
        {
            rb2d.transform.position = new Vector2(Input.GetAxis("Horizontal") * 0.01f + rb2d.transform.position.x, Input.GetAxis("Vertical") * 0.01f + rb2d.transform.position.y);
            

        }
    }
}