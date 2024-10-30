using UnityEngine;

public class CFollowCamera : MonoBehaviour
{
    public Transform target;          // 따라갈 대상 (캐릭터)
    public float smoothSpeed = 0.125f; // 카메라 이동 속도
    public Vector3 offset = new Vector3(0, 0, -10); // 초기 고정 위치와 거리 설정

    private void Start()
    {
        // 카메라 초기 위치를 (0, 0, -10)으로 고정
        transform.position = new Vector3(0, 0, -10);
    }

    private void LateUpdate()
    {
        if (target == null)
            return;

        // 목표 위치 계산 (캐릭터 위치 + 오프셋)
        Vector3 desiredPosition = target.position + offset;

        // 부드럽게 이동 (Lerp 사용)
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 카메라 위치 업데이트
        transform.position = smoothedPosition;
    }
}
