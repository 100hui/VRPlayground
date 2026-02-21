using UnityEngine;  
using UnityEngine.XR.Interaction.Toolkit;  
  
public class SocketLockPart : MonoBehaviour  
{  
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;  
  
    private void Reset() => socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();  
  
    private void OnEnable()  
    {  
        if (socket == null) socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();  
        socket.selectEntered.AddListener(OnSnapped);  
    }  
  
    private void OnDisable()  
    {  
        if (socket != null) socket.selectEntered.RemoveListener(OnSnapped);  
    }  
  
    private void OnSnapped(SelectEnterEventArgs args)  
    {  
        var t = args.interactableObject.transform;  
  
        // Make the snapped part stable  
        var rb = t.GetComponent<Rigidbody>();  
        if (rb != null)  
        {  
            rb.linearVelocity = Vector3.zero;  
            rb.angularVelocity = Vector3.zero;  
            rb.isKinematic = true;  
            rb.useGravity = false;  
        }  
  
        // Prevent re-grabbing the snapped part  
        var grab = t.GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();  
        if (grab != null) grab.enabled = false;  
    }  
}  