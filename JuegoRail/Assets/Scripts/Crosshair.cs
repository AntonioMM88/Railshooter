using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible= false;
    }

    // Update is called once per frame
    void Update()
    {
        var screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }
}
