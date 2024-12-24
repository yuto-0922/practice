using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if
        Debug.Log("何かが判定に入りました");
    }

    private void OnTriggerStay(Collider collision)
    {a
        Debug.Log("何かが判定に入り続けています");
    }

    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("何かが判定をでました");
    }
}
