using UnityEngine;  
using UnityEngine.XR.Interaction.Toolkit;  
  
public class ShowUIOnPlaced : MonoBehaviour  
{  
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;  
    public GameObject successUI;  
  
    private void Reset()  
    {  
        socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();  
    }  
  
    private void OnEnable()  
    {  
        if (socket == null)  
            socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();  
  
        socket.selectEntered.AddListener(OnPlaced);  
    }  
  
    private void OnDisable()  
    {  
        socket.selectEntered.RemoveListener(OnPlaced);  
    }  
  
    private void OnPlaced(SelectEnterEventArgs args)  
    {  
        successUI.SetActive(true);  
        Debug.Log("Object placed on pedestal!");  
    }  
}  