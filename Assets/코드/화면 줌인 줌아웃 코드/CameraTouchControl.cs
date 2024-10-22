using UnityEngine;

public class CameraTouchControl : MonoBehaviour
{
    public float panSpeed = 2f;  // 카메라 이동 속도

    void Update()
    {
        // 터치 입력 감지
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            // 터치의 상태에 따라 카메라 이동
            switch (touch.phase)
            {
                case TouchPhase.Moved:
                    // 이동한 거리에 비례해서 카메라 이동
                    Vector2 deltaPosition = touch.deltaPosition;
                    Vector3 moveVector = new Vector3(-deltaPosition.x, -deltaPosition.y, 0) * panSpeed * Time.deltaTime;
                    transform.Translate(moveVector);
                    break;
            }
        }
    }
}
