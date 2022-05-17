using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script01 : MonoBehaviour
{
    int num;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime*10);
        //Debug.Log(transform.rotation.x);
        //Debug.Log(transform.eulerAngles.y);
       // transform.position = new Vector3(0,10,0);
       //transform.rotation = Quaternion.Euler(0,90,0);
        transform.Rotate(Vector3.right * Time.deltaTime);
        
    }
}
