using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int health = 30;
    int level = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.����
        float strength = 15.5f;
        string playerName = "Jiwon";
        bool isFullLevel = false;

        //2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];

        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("�ʿ� �����ϴ� ����");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        List<string> items = new List<string>();
        items.Add("��������30");
        items.Add("��������30");


        Debug.Log("���� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        //3. ������
        int exp = 1500;

        exp = 1500 + 320;
        level = exp / 300;
        exp = exp - 10;
        strength = level * 3.1f;

        Debug.Log("����� �� ����ġ��?");
        Debug.Log(exp);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("���� �������� ���� ����ġ��?");
        Debug.Log(nextExp);

        string title = "������";
        Debug.Log("����� �̸���?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("���� �����Դϱ�? " + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�? " + isEndTutorial);

        int mana = 15;
        bool isBadCondition = health <= 50 && mana <= 20;

        string condition = isBadCondition ? "����" : "����";
        Debug.Log("����� ���°� ���޴ϱ�?" + condition);

        //4. Ű����
        // int fload string bool new List

        //5. ���ǹ�
        if (condition == "����")
        {
            Debug.Log("�÷��̾� ���°� ���ڴ� �������� ����ϼ���.");
        }
        else
        {
            Debug.Log("�÷��̾� ���°� �����ϴ�.");
        }


        if (isBadCondition && items[0] == "��������30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }
        else if(isBadCondition && items[1] == "��������30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }

   

        //6. �ݺ���
        while (health > 0 ) 
        {
            health--;
            if (health > 0)
                Debug.Log("�� �������� �Ծ����ϴ�. " + health);
            else
                Debug.Log("����Ͽ����ϴ�.");

            if (health == 10)
            {
                Debug.Log("�ص����� ����մϴ�.");
                break;
            }
        }

        for (int count =0; count < 10; count++)
        {
            health++;
            Debug.Log("�ش�� ġ����..." + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("�� ������ �ִ� ���� : " + monsters[index]);
        }

        foreach (string monster in monsters)
        {
            Debug.Log("�� ������ �ִ� ���� : " + monster);
        }

        //7. �Լ� (�޼ҵ�)
        Heal();

        for (int index=0; index < monsters.Length; index++)
        {
            Debug.Log("����" + monsters[index] + "����" + Battle(monsterLevel[index]));
        }

        //8. Ŭ����
        Actor player = new Actor();
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������ " + player.level + " �Դϴ�.");
        
    }

   
   void Heal()
    {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ�. " + health);
        
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "�̰���ϴ�.";
        else
            result = "�����ϴ�.";

        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}