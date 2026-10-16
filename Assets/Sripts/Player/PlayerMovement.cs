using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    Vector2 Input;
    [SerializeField] int moveSpeed = 5;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.linearVelocity = Input * moveSpeed;
    }

    public void Move(InputAction.CallbackContext callbackContext)
    {
        Input = callbackContext.ReadValue<Vector2>();
    }
}
