using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class ContentControll : MonoBehaviour
{
    public static ContentControll instance;
    public List<ItemsControll> itemsList= new List<ItemsControll>();
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        init();
        for (int i = 0; i < transform.childCount; i++)
        {
            itemsList.Add(transform.GetChild(i).GetComponent<ItemsControll>());
        }
    }
    //���Ƚ��г�ʼ��
    void init()
    {
        itemsList.Clear();
    }
    /// <summary>
    /// ����������Ƿ�ȫ��Ϊ��ȷ״̬
    /// </summary>
    public void CheckItems()
    {
        bool isAllTrue=false;
        for(int i=0;i<itemsList.Count;i++)
        {
            var item = itemsList[i];
            if (item.isTrue != true)
                break;
            if(item.isTrue==true&&i==itemsList.Count-1)
                isAllTrue=true;
        }
        if (isAllTrue)
        {
            Debug.Log("ȫ������������һ������");
        }
    }
}