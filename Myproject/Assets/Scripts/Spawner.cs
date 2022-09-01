using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject objectSpawn;
    [SerializeField] private GameObject Gun;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Spawn()
    {
        Gun.GetComponentInChildren<SimpleShoot>().bulletPrefab = objectSpawn;
    }
}
