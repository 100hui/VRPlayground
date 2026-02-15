using UnityEngine;

public class TeleportGoalTrigger : MonoBehaviour
{
    public TutorialManager manager;
    public int goalNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (goalNumber == 1)
        {
            manager.EnableTeleportArea2();
        }
        else if (goalNumber == 2)
        {
            manager.ShowCongrats();
        }

        gameObject.SetActive(false);
    }
}
