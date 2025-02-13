using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    void Update()
    {
    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    var pos = transform.position;
    pos.x = mousePos.x;
    pos.y = mousePos.y;
    transform.position = pos;


    }
    
}
