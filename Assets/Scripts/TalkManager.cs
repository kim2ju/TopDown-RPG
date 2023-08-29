using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(1000, new string[] { "�ȳ�?:0","���� ó�� �Ա���?:1" });
        talkData.Add(2000, new string[] { "�� ȣ���� ���� �Ƹ�����?:0, ��� �� ȣ������ ������ ����� �ִٰ� ��.:2" });
        talkData.Add(3000, new string[] { "����� �������ڴ�." });
        talkData.Add(4000, new string[] { "������ ����ߴ� ������ �ִ� å���̴�." });

        talkData.Add(1000 + 10, new string[] { "� ��.:0", "�� �������� ������ �־�.:1", "������ ȣ�� �ʿ� �絵���� �����.:0" });
        
        talkData.Add(2000 + 11, new string[] { "�� ȣ���� ������ ������ �� �ž�?:0", "�׷� �� �� ��ó�� ������ ������ ���� ���� �˷��ٰ�.:1" });

        talkData.Add(1000 + 20, new string[] { "�絵�� ����?:0", "���� �� �𸣰ڴµ�?:1" });
        talkData.Add(2000 + 20, new string[] { "ã���� �� �� ������ ��.:1" });
        talkData.Add(5000 + 20, new string[] { " ������ ã�Ҵ�." });

        talkData.Add(2000 + 21, new string[] { "ã���༭ ����.:1" });

        portraitData.Add(1000 + 0, portraitArr[0]);
        portraitData.Add(1000 + 1, portraitArr[1]);
        portraitData.Add(1000 + 2, portraitArr[2]);
        portraitData.Add(1000 + 3, portraitArr[3]);
        portraitData.Add(2000 + 0, portraitArr[4]);
        portraitData.Add(2000 + 1, portraitArr[5]);
        portraitData.Add(2000 + 2, portraitArr[6]);
        portraitData.Add(2000 + 3, portraitArr[7]);
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (!talkData.ContainsKey(id))
        {
            if (!talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 100, talkIndex);
            else
                return GetTalk(id - id % 10, talkIndex);
        }

        if(talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }
}
