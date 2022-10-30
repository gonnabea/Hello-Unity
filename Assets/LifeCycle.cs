using UnityEngine;

public class LifeCycle: MonoBehaviour

    //// 초기화 -> 물리 -> 게임로직 -> 해체 ////
{
    // 게임 오브젝트 생성할 때, 최초 실행
    //void Awake()
    //{
    //    Debug.Log("플레이어 데이터가 준비되었습니다.");
    //} 

    //// 게임 오브젝트가 활성화 되었을 떄
    //void OnEnable()
    //{
    //    Debug.Log("플레이어가 로그인했습니다.");
    //}

    //// 업데이트 시작 직전, 최초 실행
    //void Start()
    //{
    //    Debug.Log("사냥 장비를 챙겼습니다.");
    //}

    //// 물리연산 하기 전 실행되는 함수 (1초에 50 ~ 60번 정도 호출됨 - cpu 많이 사용)
    //void FixedUpdate()
    //{
    //    Debug.Log("이동~");
    //}

    // 게임로직 단계, 환경(컴퓨터 성능 등)에 따라 실행 주기가 떨어질 수 있음
    void Update()
    {
        //Debug.Log("몬스터 사냥!!");
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));
            
        }

        
        
    }

    //void LateUpdate()
    //{
    //    Debug.Log("경험치 획득.");
    //}

    //void OnDisable()
    //{
    //    Debug.Log("플레이어가 로그아웃됐습니다.");
    //}

    //void OnDestroy()
    //{
    //    Debug.Log("플레이어 데이터를 해체하였습니다."); 
    //}
    
    
}