using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    mouseLookat _mouseLookat;

    public float moveSpeed = 5f;
    public float rotateSpeed = 2f;

    private void Awake()
    {
        _mouseLookat = gameObject.GetComponent<mouseLookat>();
    }

    void Update ()
    {

        Debug.DrawRay(transform.position, _mouseLookat.aim, Color.red);
        //transform.LookAt(_mouseLookat.locationObject.transform.position + _mouseLookat.aim);
        transform.LookAt(transform.position + _mouseLookat.aim);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed *Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        /*
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        }
        */
    }
}
