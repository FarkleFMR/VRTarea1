using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    [SerializeField] private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void move()
    {
     //Player.enabled = false;
     Player.transform.position = new Vector3(Random.Range(-5,5),transform.position.y,Random.Range(-5,5));
     //Player.enabled = true;    
    }
}
