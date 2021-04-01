using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PlaceObject : MonoBehaviour
{
    public GameObject destPrefab;
    GuideArrow arrow;
    public int forwardSteps;
    public int rightSteps;
    void Start()
    {
        Invoke("PlaceObjectInPosition",3);
    }
    void PlaceObjectInPosition()
    {
        arrow = FindObjectOfType<GuideArrow>();
        GameObject instance = Instantiate(destPrefab, transform.position + transform.forward * (forwardSteps*0.7f+ (forwardSteps > 0 ? 0.5f : -0.5f)) + transform.right * (rightSteps * 0.7f + (rightSteps > 0 ? 0.5f : -0.5f)), Quaternion.identity);
        arrow.targetObject = instance.transform;
    }
}
