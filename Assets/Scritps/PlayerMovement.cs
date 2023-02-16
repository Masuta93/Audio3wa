using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _speed;

    private CharacterController _characterController;

    private void Awake()
    {
        _characterController= GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Debug.Log(horizontalInput);

        Vector3 direction = transform.right * horizontalInput + transform.forward * verticalInput;

        Vector3 move = direction.normalized * _speed * Time.deltaTime;

        _characterController.Move(move);
    }
}
