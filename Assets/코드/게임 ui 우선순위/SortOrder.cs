using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortOrder : MonoBehaviour
{
    [SerializeField] GameObject Scroll;
    [SerializeField] GameObject Character;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("��ũ�� ����" + Scroll.transform.GetSiblingIndex());
        Debug.Log("ĳ���� ����" + Character.transform.GetSiblingIndex());
        Character.transform.SetSiblingIndex(0);
        Debug.Log("��ũ�� ����" + Scroll.transform.GetSiblingIndex());
        Debug.Log("ĳ���� ����" + Character.transform.GetSiblingIndex());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
