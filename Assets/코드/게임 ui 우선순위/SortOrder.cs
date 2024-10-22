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
        Debug.Log("스크롤 순위" + Scroll.transform.GetSiblingIndex());
        Debug.Log("캐릭터 순위" + Character.transform.GetSiblingIndex());
        Character.transform.SetSiblingIndex(0);
        Debug.Log("스크롤 순위" + Scroll.transform.GetSiblingIndex());
        Debug.Log("캐릭터 순위" + Character.transform.GetSiblingIndex());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
