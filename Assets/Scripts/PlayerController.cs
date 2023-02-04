using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField]
    public Vector2 _moveInput;

    [SerializeField]
    private float _moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        #region MOVEMENT
        _rb.AddForce(_moveInput * _moveSpeed);
        #endregion
    }

    public void Move(InputAction.CallbackContext context)
    {
        Debug.Log("test");
        _moveInput = context.ReadValue<Vector2>();
    }
}
