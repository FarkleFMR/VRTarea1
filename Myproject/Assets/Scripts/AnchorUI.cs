using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objectToFollow;
    public Vector3 offset;
    private RectTransform rectTransform = null;
    private Camera cam;
    void Start()
    {
        
    
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rectTransform.position = objectToFollow.position + offset;

    }
}
