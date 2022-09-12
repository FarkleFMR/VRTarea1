using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ControlHit : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Player;
    public XRRayInteractor rayInteractor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void test(){
        RaycastHit hit;
        rayInteractor.TryGetCurrent3DRaycastHit(out hit);
        Vector3 localHit = transform.InverseTransformPoint(hit.point);
        Debug.Log(localHit);
        Player.transform.position = localHit;
    }
}
