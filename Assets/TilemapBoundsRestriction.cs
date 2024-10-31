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
        // Å¸ÀÏ¸ÊÀÇ Å©±â
        BoundsInt bounds = tilemap.cellBounds;
        Vector3 tilemapMin = tilemap.GetCellCenterWorld(bounds.min);
        Vector3 tilemapMax = tilemap.GetCellCenterWorld(bounds.max);

        // Ä«¸Þ¶ó ½Ã¾ß ¿µ¿ª ±¸ÇÏ±â
        float cameraOrthoSize = mainCamera.orthographicSize;
        float cameraAspect = mainCamera.aspect;
        float cameraHalfWidth = cameraOrthoSize * cameraAspect;
        float cameraHalfHeight = cameraOrthoSize;

        // Á¦ÇÑ ¿µ¿ª ¼³Á¤
        float maxX = tilemapMax.x - cameraHalfWidth;
        float minX = tilemapMin.x + cameraHalfWidth;
        float maxY = tilemapMax.y - cameraHalfHeight;
        float minY = tilemapMin.y + cameraHalfHeight;

        // Ä«¸Þ¶ó À§Ä¡¸¦ Á¦ÇÑ ¿µ¿ª ³»·Î Á¶Àý
        Vector3 clampedCameraPosition = mainCamera.transform.position;
        clampedCameraPosition.x = Mathf.Clamp(clampedCameraPosition.x, minX, maxX);
        clampedCameraPosition.y = Mathf.Clamp(clampedCameraPosition.y, minY, maxY);

        // »õ·Î¿î Ä«¸Þ¶ó À§Ä¡ Àû¿ë
        mainCamera.transform.position = clampedCameraPosition;
<<<<<<< HEAD
=======
        //123
>>>>>>> parent of 51286c5 (ëŒ€í™” ê¸°ëŠ¥ ì¶”ê°€)
    }
}
