using UnityEngine;

public class CameraAspectRatio : MonoBehaviour
{
    // ���ϴ� Aspect Ratio (����:���� ����)
    public float targetAspectRatio = 16f / 9f;

    void Start()
    {
        // ���� ī�޶� ��������
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            // ���� ����̽��� ȭ�� ���� ���� ����
            float currentAspectRatio = (float)Screen.width / Screen.height;

            // ���ϴ� Aspect Ratio�� ���� Width �Ǵ� Height�� ����
            float orthographicSize = mainCamera.orthographicSize;
            if (currentAspectRatio > targetAspectRatio)
            {
                // ���� ������ �� ���� ��, Width�� �÷���
                mainCamera.orthographicSize = orthographicSize * (currentAspectRatio / targetAspectRatio);
            }
            else
            {
                // ���� ������ �� ���� ��, Height�� �÷���
                mainCamera.orthographicSize = orthographicSize / (currentAspectRatio / targetAspectRatio);
            }
        }
    }
}
