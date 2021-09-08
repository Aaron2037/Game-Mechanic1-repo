using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemove : MonoBehaviour
{
    //variables
    public float speed = 10f;
    private Vector3 mousePos;


    void Start()
    {
        //sets object position to mouse position
        mousePos = transform.position;
    }

    void Update()
    {
        //every time mouse is pressed/clicked the object moves closer to the mouse
        if (Input.GetMouseButton(0))
        {
            if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x > mousePos.x)
                mousePos.x = mousePos.x + speed * Time.deltaTime;
            if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < mousePos.x)
                mousePos.x = mousePos.x - speed * Time.deltaTime;
            if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y > mousePos.y)
                mousePos.y = mousePos.y + speed * Time.deltaTime;
            if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < mousePos.y)
                mousePos.y = mousePos.y - speed * Time.deltaTime;
            transform.position = mousePos;
        }
    }
}
