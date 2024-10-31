using UnityEngine;

public class CameraTouchControl : MonoBehaviour
{
    public float panSpeed = 2f;  // ī�޶� �̵� �ӵ�

    void Update()
    {
        // ��ġ �Է� ����
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            // ��ġ�� ���¿� ���� ī�޶� �̵�
            switch (touch.phase)
            {
                case TouchPhase.Moved:
                    // �̵��� �Ÿ��� ����ؼ� ī�޶� �̵�
                    Vector2 deltaPosition = touch.deltaPosition;
                    Vector3 moveVector = new Vector3(-deltaPosition.x, -deltaPosition.y, 0) * panSpeed * Time.deltaTime;
                    transform.Translate(moveVector);
                    break;
            }
        }
    }
}
