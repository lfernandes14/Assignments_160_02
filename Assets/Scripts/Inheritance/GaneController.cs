using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaneController : MonoBehaviour
{
    private Gun tommyGun;
    private Gun revolver;

    // Start is called before the first frame update
    void Start()
    {
        tommyGun = new Gun();
        revolver = new Gun("Revolver");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
