using UnityEngine;
public class Destination : MonoBehaviour
{
    private Animation imageAnim;
    private MeshRenderer arrow;

    private void Awake()
    {
        imageAnim = GameObject.Find("Image").GetComponent<Animation>();
        arrow = GameObject.Find("Arrow").GetComponentInChildren<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Arrow"))
        {
            imageAnim.Play("Show");
            arrow.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("Arrow"))
        {
            imageAnim.Play("Hide");
            arrow.enabled = true;
        }
    }
}
