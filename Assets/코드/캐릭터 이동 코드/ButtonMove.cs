using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody2D rid2D;
    public GameObject Character;
    public bool LeftUp;
    public bool Up = false;
    public bool RightUp;
    public bool Left = false;
    public bool Right = false;
    public bool LeftDown;
    public bool Down = false;
    public bool RightDown;
    void Start()
    {
        rid2D = GetComponent<Rigidbody2D>();    
        
    }


    public void LeftUpTrueButton()
    {
        LeftUp = true;
    }
    public void LeftUpFalseButton()
    {
        LeftUp = false;
    }
    public void UpTrueButton()
    {
        Up = true;
    }
    public void UpfalseButton()
    {
        Up = false;
    }
    public void RightUpTrueButton()
    {
        RightUp = true;
    }
    public void RightUpFalseButton()
    {
        RightUp = false;
    }
    public void LeftTrueButton()
    {
        Left = true;
    }
    public void LeftfalseButton()
    {
        Left = false;
    }

    public void RightTrueButton()
    {
        Right = true;
    }
    public void RightFalseButton()
    {
        Right = false;
    }
    public void LeftDownTrueButton()
    {
        LeftDown = true;
    }
    public void LeftDownFalseButton()
    {
        LeftDown = false;
    }
    public void DownTrueButton()
    {
        Down = true;
    }
    public void DownFalseButton()
    {
        Down = false;
    }
    public void RightDownTrueButton()
    {
        RightDown = true;
    }
    public void RightDownFalseButton()
    {
        RightDown = false;
    }

    void Update()
    {
        if (LeftUp == true)
        {
            Character.transform.Translate(new Vector3(-speed * Time.deltaTime, speed * Time.deltaTime, 0));
        }
        if (Up == true)
        {
            Character.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (RightUp == true)
        {
            Character.transform.Translate(new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0));
        }
        if (Left == true)
        {
            Character.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }

        if (Right == true)
        {
            Character.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (LeftDown == true)
        {
            Character.transform.Translate(new Vector3(-speed * Time.deltaTime, -speed * Time.deltaTime, 0));
        }

        if (Down == true)
        {
            Character.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (RightDown == true)
        {
            Character.transform.Translate(new Vector3(speed * Time.deltaTime, -speed * Time.deltaTime, 0));
        }





    }
}
