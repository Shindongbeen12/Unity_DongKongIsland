using UnityEngine;

public class ResolutionManager : MonoBehaviour
{

    public int YourWidth = 720;
    public int YourHeight = 1080;
    void Start()
    {
        Screen.SetResolution(YourWidth, YourHeight, true);
    }
    void Update()
    {
        //Screen.SetResolution(YourWidth, YourHeight, true);
    }
}