using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 jumpHeight;
    public float _automatic_movement_speed = 10f; // Speed des Movements
    public bool grounded;

    void Start()
    {
        grounded = true; // Zum Start des Spiels automatisch auf Grounded
    }
    void Update()
    {
        transform.Translate(Vector3.right * _automatic_movement_speed * Time.deltaTime); // Automatisches Movement nach Rechts

        if (grounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)) // Key zum Springen
            {
                GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse); // Force nach oben
                grounded = false; // Grounded nach Sprung auf False

            }else {
                
            }
        }
    }
}