using UnityEngine;
using UnityEngine.UI;

public class ButtonColorController : MonoBehaviour
{
    private Button button;
    [SerializeField] public GameObject Talk;
    public bool TalkActive = true;
    void Start()
    {
        
    }

    public void OnButtonClick()
    {
        
        if(TalkActive == true)
        {
            Talk.SetActive(false);
            TalkActive = false;
        }
        else if(TalkActive == false)
        {
            Talk.SetActive(true);
            TalkActive = true;
        }
        
    }
}
