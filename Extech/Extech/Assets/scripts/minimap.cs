using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour {

    GameObject player;
    Transform pTrans;

    public float yDis = 25f;

    void Start ()
    {
        player = GameObject.FindWithTag("Player");
        pTrans = player.GetComponent<Transform>();
    }

	void Update ()
    {
        transform.position = new Vector3(pTrans.position.x, pTrans.position.y + yDis, pTrans.position.z);
    }
}
