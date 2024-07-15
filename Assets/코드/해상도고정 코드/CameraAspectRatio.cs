using UnityEngine;

public class CameraAspectRatio : MonoBehaviour
{
    // 원하는 Aspect Ratio (가로:세로 비율)
    public float targetAspectRatio = 16f / 9f;

    void Start()
    {
        // 메인 카메라 가져오기
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            // 현재 디바이스의 화면 가로 세로 비율
            float currentAspectRatio = (float)Screen.width / Screen.height;

            // 원하는 Aspect Ratio에 따라 Width 또는 Height를 조절
            float orthographicSize = mainCamera.orthographicSize;
            if (currentAspectRatio > targetAspectRatio)
            {
                // 현재 비율이 더 넓을 때, Width를 늘려줌
                mainCamera.orthographicSize = orthographicSize * (currentAspectRatio / targetAspectRatio);
            }
            else
            {
                // 현재 비율이 더 높을 때, Height를 늘려줌
                mainCamera.orthographicSize = orthographicSize / (currentAspectRatio / targetAspectRatio);
            }
        }
    }
}
