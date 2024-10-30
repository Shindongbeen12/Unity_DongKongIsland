using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagCollider : MonoBehaviour
{
    // 2D 충돌 감지 메서드
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 오브젝트의 태그가 "Glass"인지 확인
        if (collision.gameObject.CompareTag("Glass"))
        {
            Debug.Log("Glass와 충돌했습니다!");

            // 원하는 행동을 추가 (예: 오브젝트 파괴, 효과 발생 등)
            // Destroy(collision.gameObject);  // Glass 오브젝트 파괴 예시
        }
    }
}
