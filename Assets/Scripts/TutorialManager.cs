using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject zone2;
    public GameObject zone3;

    public GameObject teleportArea1;
    public GameObject teleportArea2;
    public GameObject congratsCanvas;
    public GameObject ca5; 

    public void ActivateZone2() => zone2.SetActive(true);
    public void ActivateZone3() => zone3.SetActive(true);

    public void EnableTeleportArea1()
    {
        teleportArea1.SetActive(true);
    }

    public void EnableTeleportArea2()
    {
        teleportArea2.SetActive(true);
    }

    public void ShowCongrats()
    {
        congratsCanvas.SetActive(true);
        ca5.SetActive(true);
    }
}
