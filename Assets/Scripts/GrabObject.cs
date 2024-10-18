using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabObject : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        Debug.Log("Object grabbed!");
    }

    void OnRelease(SelectExitEventArgs args)
    {
        Debug.Log("Object released!");
    }
}