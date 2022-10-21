using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieDieDieMyDarling : MonoBehaviour
{
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D truc)
    {   Debug.Log("Touche");
        if(truc.tag == "Checkpoint")
        {
        spawn.transform.position = transform.position;
        Destroy(truc);
        }
        if(truc.tag == "Kill")
        {
        Debug.Log("Meurt");
        transform.position = spawn.transform.position;
        }
    }
}
