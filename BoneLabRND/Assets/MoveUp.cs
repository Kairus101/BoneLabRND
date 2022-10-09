using SLZ.Marrow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("start");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * 0.01f * Time.deltaTime;
        print("update");
    }
}
