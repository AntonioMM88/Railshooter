using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xySpeed = 18;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * xySpeed);
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * xySpeed);

       

    }

}
