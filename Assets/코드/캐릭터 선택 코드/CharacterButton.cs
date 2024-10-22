using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterButton : MonoBehaviour
{
    [SerializeField]
    public Character_Man Man; //남자 캐릭터 출력
    [SerializeField]
    public Character_Woman Woman; //여자 캐릭터 출력
    [SerializeField]
    public Character_SKill Skill; //스킬 출력

    [SerializeField]
    public GameObject ChoicePanel;

    [SerializeField]
    public Text Sex;
    [SerializeField]
    public Text Job;
    [SerializeField]
    public GameObject Warning;

    public int Active = 0;


    //버튼 누를 시 출력
    public void FarmerButton()
    {
        Man.Farmer();
        Woman.Farmer();
        Skill.Farmer();
    }
    public void FisherButton()
    {
        Man.Fisher();
        Woman.Fisher();
        Skill.Fisher();
    }
    public void AxerButton()
    {
        Man.Axer();
        Woman.Axer();
        Skill.Axer();
    }
    public void BuilderButton()
    {
        Man.Builder();
        Woman.Builder();
        Skill.Builder();
    }
    public void MinerButton()
    {
        Man.Miner();
        Woman.Miner();
        Skill.Miner();
    }
    public void HunterButton()
    {
        Man.Hunter();
        Woman.Hunter();
        Skill.Hunter();
    }

    //버튼 누를 시 다음과 같은 내용 출력

    public void Man_Farmer()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 남자";
        Job.text = "직업 : 농부";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
        
    }
    public void Woman_Farmer()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 여자";
        Job.text = "직업 : 농부";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }
    public void Man_Fisher()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 남자";
        Job.text = "직업 : 낚시꾼";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }
    public void Woman_Fisher()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 여자";
        Job.text = "직업 : 낚시꾼";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }

    public void Man_Axer()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 남자";
        Job.text = "직업 : 나무꾼";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }
    public void Woman_Axer()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 여자";
        Job.text = "직업 : 나무꾼";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }

    public void Man_Builder()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 남자";
        Job.text = "직업 : 건축가";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }
    public void Woman_Builder()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 여자";
        Job.text = "직업 : 건축가";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }

    public void Man_Miner()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 남자";
        Job.text = "직업 : 광부";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }
    public void Woman_Miner()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 여자";
        Job.text = "직업 : 광부";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }

    public void Man_Hunter()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 남자";
        Job.text = "직업 : 사냥꾼";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }
    public void Woman_Hunter()
    {
        ChoicePanel.SetActive(true);
        Sex.text = "성별 : 여자";
        Job.text = "직업 : 사냥꾼";
        Warning.SetActive(true);
        StartCoroutine(MyCoroutine());
    }
    public void ReChoice()
    {
        ChoicePanel.SetActive(false);
        StopAllCoroutines();
        
        
    }
    IEnumerator MyCoroutine()
    {
        
        while (true)
        {
            // 0.5초 코루틴
            yield return new WaitForSeconds(0.5f);
            
            
            if(Warning.activeSelf)
            {
                Warning.SetActive(false);
            }
            else
            {
                Warning.SetActive(true);
            }
            
            
        }
    }






}
