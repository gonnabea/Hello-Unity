using UnityEngine;

public class Controls : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButtonDown("Fire1")) 
            Debug.Log("점프!");

        if (Input.GetButton("Fire1"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("슈퍼 점프!!");
    }
}
