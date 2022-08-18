using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject objectSpawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Spawn()
    {
        Instantiate(objectSpawn,transform.position, transform.rotation);
    }
}
