using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    private CharacterController CharacterController;

    public float vel = 5f;

    void Start()
    {
        CharacterController = GetComponent<CharacterController>();    
    }

    void Update()
    {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

            CharacterController.Move(move * Time.deltaTime * vel);    
    }
}
