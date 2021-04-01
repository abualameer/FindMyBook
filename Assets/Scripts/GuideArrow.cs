using UnityEngine;

public class GuideArrow: MonoBehaviour
{
    public Transform targetObject;

    void Update()
    {
        if(targetObject) transform.LookAt(targetObject);
    }
}
