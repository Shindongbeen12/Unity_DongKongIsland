using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_SKill : MonoBehaviour
{
    public GameObject Skill;
    public int i;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Farmer()
    {
        for (i = 0; i < 6; i++)
        {
            Skill = transform.GetChild(i).gameObject;
            if (i == 0)
            {
                Skill.SetActive(true);
            }
            else
            {
                Skill.SetActive(false);
            }
        }


    }
    public void Fisher()
    {
        for (i = 0; i < 6; i++)
        {
            Skill = transform.GetChild(i).gameObject;
            if (i == 1)
            {
                Skill.SetActive(true);
            }
            else
            {
                Skill.SetActive(false);
            }
        }


    }
    public void Axer()
    {
        for (i = 0; i < 6; i++)
        {
            Skill = transform.GetChild(i).gameObject;
            if (i == 2)
            {
                Skill.SetActive(true);
            }
            else
            {
                Skill.SetActive(false);
            }
        }


    }
    public void Builder()
    {
        for (i = 0; i < 6; i++)
        {
            Skill = transform.GetChild(i).gameObject;
            if (i == 3)
            {
                Skill.SetActive(true);
            }
            else
            {
                Skill.SetActive(false);
            }
        }


    }
    public void Miner()
    {
        for (i = 0; i < 6; i++)
        {
            Skill = transform.GetChild(i).gameObject;
            if (i == 4)
            {
                Skill.SetActive(true);
            }
            else
            {
                Skill.SetActive(false);
            }
        }


    }
    public void Hunter()
    {
        for (i = 0; i < 6; i++)
        {
            Skill = transform.GetChild(i).gameObject;
            if (i == 5)
            {
                Skill.SetActive(true);
            }
            else
            {
                Skill.SetActive(false);
            }
        }


    }


}
