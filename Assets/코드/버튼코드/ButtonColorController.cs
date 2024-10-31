using UnityEngine;
using UnityEngine.UI;

public class ButtonColorController : MonoBehaviour
{
    private Button button;
<<<<<<< HEAD
    [SerializeField] public GameObject Talk1;
    [SerializeField] public GameObject Talk2;
    public bool TalkActive = true;
=======

>>>>>>> parent of 51286c5 (대화 기능 추가)
    void Start()
    {
        
    }

    public void OnButtonClick()
    {
<<<<<<< HEAD
        
        if(TalkActive == true)
        {
            Talk1.SetActive(false);
            Talk2.SetActive(false);
            TalkActive = false;
        }
        else if(TalkActive == false)
        {
            Talk1.SetActive(true);
            Talk2.SetActive(true);
            TalkActive = true;
        }
        
=======
        Debug.Log("��ưŬ��");
>>>>>>> parent of 51286c5 (대화 기능 추가)
    }
}
