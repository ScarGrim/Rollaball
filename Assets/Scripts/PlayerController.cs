using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent <Rigidbody>();
    }

    void OnMove(InputValue movementvalue)
    {
        //tutorial
        Vector2 movementVector = movementvalue.Get<Vector2>();

        //added by function default
        //Vector3 movement = new Vector3(inputVector.x, 0, inputVector.y);
        //transform.Translate(movement * Time.deltaTime * 5f);

        //tutorial
        movementX = movementVector.x;
        movementY = movementVector.y;

    }
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0, movementY);

        //(movementVector) ? edit to movement
        rb.AddForce(movement * speed);
   }
    // Update is called once per frame
    //void Update() {}
}
