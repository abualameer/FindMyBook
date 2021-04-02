using UnityEngine;
using UnityEngine.UI;
public class GuideArrow: MonoBehaviour
{
    public Transform targetObject;
    public Text guideText;
    void Update()
    {
        if (targetObject)
        { 
            transform.LookAt(targetObject);
            float dist = Vector3.Distance(transform.position, targetObject.position);
            int distanceInMeters = Mathf.RoundToInt(dist);
            if (dist > 0.7f)
                guideText.text = "You are <B>" + distanceInMeters + "</B> meters away from your book";
            else
                guideText.text = "";
        }
        else
        {
            guideText.text = "verifying your book's location";
        }
    }
}
