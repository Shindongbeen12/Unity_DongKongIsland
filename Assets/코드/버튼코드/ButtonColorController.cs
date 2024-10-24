using UnityEngine;
using UnityEngine.UI;

public class ButtonColorController : MonoBehaviour
{
    private Button button;
    [SerializeField] public GameObject Talk1;
    [SerializeField] public GameObject Talk2;
    public bool TalkActive = true;
    void Start()
    {
        
    }

    public void OnButtonClick()
    {
        
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
        
    }
}
