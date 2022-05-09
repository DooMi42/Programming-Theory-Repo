using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE down here
public class BallScript : MonoBehaviour
{
    //

    //ENCAPSULATION down here
    private float m_speed = 5f;
    public float speed
    {
        get { return m_speed; }
        set { m_speed = value; }
    }
    //

    private Vector3 dir = Vector3.left;

    private void Update()
    {
        Move();
    }
    //POLYMORPHISM down here
    public virtual void Move()
    {
        speed = 5f;

        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.x <= -4)
        {
            dir = Vector3.right;
        }
        else if (transform.position.x >= 4)
        {
            dir = Vector3.left;
        }
    }
    //
}
