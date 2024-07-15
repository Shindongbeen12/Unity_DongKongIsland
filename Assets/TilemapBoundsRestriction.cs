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
        // Ÿ�ϸ��� ũ��
        BoundsInt bounds = tilemap.cellBounds;
        Vector3 tilemapMin = tilemap.GetCellCenterWorld(bounds.min);
        Vector3 tilemapMax = tilemap.GetCellCenterWorld(bounds.max);

        // ī�޶� �þ� ���� ���ϱ�
        float cameraOrthoSize = mainCamera.orthographicSize;
        float cameraAspect = mainCamera.aspect;
        float cameraHalfWidth = cameraOrthoSize * cameraAspect;
        float cameraHalfHeight = cameraOrthoSize;

        // ���� ���� ����
        float maxX = tilemapMax.x - cameraHalfWidth;
        float minX = tilemapMin.x + cameraHalfWidth;
        float maxY = tilemapMax.y - cameraHalfHeight;
        float minY = tilemapMin.y + cameraHalfHeight;

        // ī�޶� ��ġ�� ���� ���� ���� ����
        Vector3 clampedCameraPosition = mainCamera.transform.position;
        clampedCameraPosition.x = Mathf.Clamp(clampedCameraPosition.x, minX, maxX);
        clampedCameraPosition.y = Mathf.Clamp(clampedCameraPosition.y, minY, maxY);

        // ���ο� ī�޶� ��ġ ����
        mainCamera.transform.position = clampedCameraPosition;
        //123
    }
}
