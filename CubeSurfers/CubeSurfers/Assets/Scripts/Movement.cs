using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float moveForwardSpeed;
  
    [SerializeField] float LeftRightSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")*LeftRightSpeed*Time.deltaTime;
        this.transform.Translate(horizontal, 0, moveForwardSpeed * Time.deltaTime);
    }
}
