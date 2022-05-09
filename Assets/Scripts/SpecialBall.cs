using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//INHERITANCE down here
public class SpecialBall : BallScript
{
    //
    public Image sText;
    private Vector3 dirr = Vector3.forward;

    //POLYMORPHISM down here
    public override void Move()
    {
        speed = 15f;

        transform.Translate(dirr * speed * Time.deltaTime);

        if (transform.position.z <= -7)
        {
            dirr = Vector3.forward;
        }
        else if (transform.position.z >= 7)
        {
            dirr = Vector3.back;
        }
    }
    //

    //ABSTRACTION down here
    private void Start()
    {
        sText.enabled = false;
    }
    //
    private void Update()
    {
        if(speed > 0)
        {
            Move();
        }
    }
    //ABSTRACTION down here
    void OnMouseDown()
    {
        sText.enabled = !sText.enabled;
    }
    //
}
