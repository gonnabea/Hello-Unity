using UnityEngine;

public class Controls : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetButtonDown("Fire1")) 
            Debug.Log("����!");

        if (Input.GetButton("Fire1"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Fire1"))
            Debug.Log("���� ����!!");
    }
}
