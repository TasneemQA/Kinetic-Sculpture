using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xNew = Mathf.Sin(Time.time) * 30f;  
        float yNew = Mathf.Cos(Time.time) * 30f;
        transform.rotation = Quaternion.Euler(new Vector3(xNew, yNew, 0));
    }
}
