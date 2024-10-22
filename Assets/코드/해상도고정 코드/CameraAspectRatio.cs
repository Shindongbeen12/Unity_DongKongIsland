using UnityEngine;

public class CameraAspectRatio : MonoBehaviour
{
    // 16:9 설정
    public float targetAspectRatio = 16f / 9f;

    void Start()
    {
        
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            
            float currentAspectRatio = (float)Screen.width / Screen.height;

            
            float orthographicSize = mainCamera.orthographicSize;
            if (currentAspectRatio > targetAspectRatio)
            {
                
                mainCamera.orthographicSize = orthographicSize * (currentAspectRatio / targetAspectRatio);
            }
            else
            {
               
                mainCamera.orthographicSize = orthographicSize / (currentAspectRatio / targetAspectRatio);
            }
        }
    }
}
