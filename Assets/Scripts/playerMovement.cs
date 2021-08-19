using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float _hInput = 0;
    private float _vInput = 0;
    public int movementSpeed;
    Rigidbody2D rigidbody2D;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
        MovePlayer();
    }

    private void FixedUpdate()
    {
        
    }

    private void GetPlayerInput()
    {
        _hInput = Input.GetAxis("Horizontal");
        _vInput = Input.GetAxis("Vertical");

    }

    private void MovePlayer()
    {
        Vector3 directionVector = new Vector3(_hInput, _vInput, 0);
      //  rigidbody2D.velocity = directionVector.normalized * movementSpeed;
        transform.Translate(directionVector.normalized * Time.deltaTime * movementSpeed);


    }
}
