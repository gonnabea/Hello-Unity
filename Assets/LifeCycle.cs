using UnityEngine;

public class LifeCycle: MonoBehaviour

    //// �ʱ�ȭ -> ���� -> ���ӷ��� -> ��ü ////
{
    // ���� ������Ʈ ������ ��, ���� ����
    //void Awake()
    //{
    //    Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    //} 

    //// ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    //void OnEnable()
    //{
    //    Debug.Log("�÷��̾ �α����߽��ϴ�.");
    //}

    //// ������Ʈ ���� ����, ���� ����
    //void Start()
    //{
    //    Debug.Log("��� ��� ì����ϴ�.");
    //}

    //// �������� �ϱ� �� ����Ǵ� �Լ� (1�ʿ� 50 ~ 60�� ���� ȣ��� - cpu ���� ���)
    //void FixedUpdate()
    //{
    //    Debug.Log("�̵�~");
    //}

    // ���ӷ��� �ܰ�, ȯ��(��ǻ�� ���� ��)�� ���� ���� �ֱⰡ ������ �� ����
    void Update()
    {
        //Debug.Log("���� ���!!");
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));
            
        }

        
        
    }

    //void LateUpdate()
    //{
    //    Debug.Log("����ġ ȹ��.");
    //}

    //void OnDisable()
    //{
    //    Debug.Log("�÷��̾ �α׾ƿ��ƽ��ϴ�.");
    //}

    //void OnDestroy()
    //{
    //    Debug.Log("�÷��̾� �����͸� ��ü�Ͽ����ϴ�."); 
    //}
    
    
}