using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLookat : MonoBehaviour {

    public Camera _camera;

    public Transform target;
    public Vector3 aim;

    public GameObject locationObject;

    private void Update()
    {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            aim = hit.point;
        }

        //locationObject.transform.position = new Vector3(aim.x, aim.y, aim.z);
    }
}
