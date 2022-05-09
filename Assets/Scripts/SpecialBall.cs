using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialBall : BallScript
{
    public Image sText;
    private Vector3 dirr = Vector3.forward;
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
    private void Start()
    {
        sText.enabled = false;
    }
    private void Update()
    {
        if(speed > 0)
        {
            Move();
        }
    }
    void OnMouseDown()
    {
        sText.enabled = !sText.enabled;
    }

}
