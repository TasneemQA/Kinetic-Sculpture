using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionOfSphere : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xNew = Mathf.Sin(Time.time);
        transform.rotation = Quaternion.Euler(new Vector3(0, xNew * 20f, 0));
    }
}
