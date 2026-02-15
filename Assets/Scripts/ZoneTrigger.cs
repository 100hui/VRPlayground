using UnityEngine;

public class ZoneTrigger : MonoBehaviour
{
    public TutorialManager manager;
    public int zoneNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (zoneNumber == 1)
        {
            manager.ActivateZone2();
        }
        else if (zoneNumber == 2)
        {
            manager.ActivateZone3();
        }
        else if (zoneNumber == 3)
        {
            manager.EnableTeleportArea1();
        }

        gameObject.SetActive(false);
    }
}
