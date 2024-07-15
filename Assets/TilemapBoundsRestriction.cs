using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapBoundsRestriction : MonoBehaviour
{
    private Camera mainCamera;
    private Tilemap tilemap;
    private TilemapRenderer tilemapRenderer;
    public int a;
    void Start()
    {
        
        mainCamera = Camera.main;
        tilemap = GetComponent<Tilemap>();
        tilemapRenderer = GetComponent<TilemapRenderer>();
    }

    void LateUpdate()
    {
        // 타일맵의 크기
        BoundsInt bounds = tilemap.cellBounds;
        Vector3 tilemapMin = tilemap.GetCellCenterWorld(bounds.min);
        Vector3 tilemapMax = tilemap.GetCellCenterWorld(bounds.max);

        // 카메라 시야 영역 구하기
        float cameraOrthoSize = mainCamera.orthographicSize;
        float cameraAspect = mainCamera.aspect;
        float cameraHalfWidth = cameraOrthoSize * cameraAspect;
        float cameraHalfHeight = cameraOrthoSize;

        // 제한 영역 설정
        float maxX = tilemapMax.x - cameraHalfWidth;
        float minX = tilemapMin.x + cameraHalfWidth;
        float maxY = tilemapMax.y - cameraHalfHeight;
        float minY = tilemapMin.y + cameraHalfHeight;

        // 카메라 위치를 제한 영역 내로 조절
        Vector3 clampedCameraPosition = mainCamera.transform.position;
        clampedCameraPosition.x = Mathf.Clamp(clampedCameraPosition.x, minX, maxX);
        clampedCameraPosition.y = Mathf.Clamp(clampedCameraPosition.y, minY, maxY);

        // 새로운 카메라 위치 적용
        mainCamera.transform.position = clampedCameraPosition;
        //123
    }
}
