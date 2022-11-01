using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonist : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform;   
    [SerializeField] private LayerMask playerMask;
    
    [SerializeField] string characterName;
    [SerializeField] int levelUp;
    private int characterLevel = 1;
    

    private bool jumpKeyInput;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();

        CharacterInfo(characterName, characterLevel + levelUp);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space was pressed down");
            jumpKeyInput = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }
    
    private void FixedUpdate()
    {
        rigidbodyComponent.velocity = new Vector3(horizontalInput * 3, rigidbodyComponent.velocity.y, 0);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.5f, playerMask).Length == 0)
        {
            return; 
        }

        if (jumpKeyInput)
        {
            rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyInput = false;
        }

        if (groundCheckTransform.position.y < -2)
        {
            Debug.Log("YOU DIED");

        }
    }

    void CharacterInfo(string a, int b)
    {
        Debug.LogFormat("Player name is {0} and player level is {1}", a, b);
      
    }



}
