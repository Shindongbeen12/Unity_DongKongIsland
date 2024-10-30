using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody2D rid2D;
    public GameObject Character;
    public bool LeftUp;
    public bool Up;
    public bool RightUp;
    public bool Left;
    public bool Right;
    public bool LeftDown;
    public bool Down;
    public bool RightDown;

    public float y1 = 11.0f;

    


    void Start()
    {
        rid2D = GetComponent<Rigidbody2D>();
    }

    // 버튼 눌림/떼기 함수들...
    public void LeftUpTrueButton() { LeftUp = true; }
    public void LeftUpFalseButton() { LeftUp = false; }
    public void UpTrueButton() { Up = true; }
    public void UpfalseButton() { Up = false; }
    public void RightUpTrueButton() { RightUp = true; }
    public void RightUpFalseButton() { RightUp = false; }
    public void LeftTrueButton() { Left = true; }
    public void LeftfalseButton() { Left = false; }
    public void RightTrueButton() { Right = true; }
    public void RightFalseButton() { Right = false; }
    public void LeftDownTrueButton() { LeftDown = true; }
    public void LeftDownFalseButton() { LeftDown = false; }
    public void DownTrueButton() { Down = true; }
    public void DownFalseButton() { Down = false; }
    public void RightDownTrueButton() { RightDown = true; }
    public void RightDownFalseButton() { RightDown = false; }

    void Update()
    {
        Vector3 newPosition = Character.transform.position;

        // 각 방향에 대해 제한된 범위 내에서만 이동
        if (LeftUp && newPosition.x > -11.0f && newPosition.y < y1)
        {
            newPosition += new Vector3(-speed * Time.deltaTime, speed * Time.deltaTime, 0);
        }
        if (Up && newPosition.y < y1)
        {
            newPosition += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (RightUp && newPosition.x < 11.0f && newPosition.y < y1)
        {
            newPosition += new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);
        }
        if (Left && newPosition.x > -11.0f)
        {
            newPosition += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Right && newPosition.x < 11.0f)
        {
            newPosition += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (LeftDown && newPosition.x > -11.0f)
        {
            newPosition += new Vector3(-speed * Time.deltaTime, -speed * Time.deltaTime, 0);
        }
        if (Down && newPosition.y > -0.0f)
        {
            newPosition += new Vector3(0, -speed * Time.deltaTime, 0);
        }
        if (RightDown && newPosition.x < 11.0f)
        {
            newPosition += new Vector3(speed * Time.deltaTime, -speed * Time.deltaTime, 0);
        }

        // 새로운 위치 적용
        Character.transform.position = newPosition;
    }
}
