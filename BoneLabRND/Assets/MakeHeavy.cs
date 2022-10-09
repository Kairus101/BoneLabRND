using SLZ.Marrow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeHeavy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().mass = 9999999;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
