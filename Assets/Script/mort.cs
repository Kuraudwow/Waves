using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mort : MonoBehaviour
{
  //  public GameObject lava;
    private Vector3 spawn;
   // private lavaquimonte lavaquimonteparla;
   // private levierlava lavaquimonteparle;

        [SerializeField] private AudioSource checkpointsound;

    // Start is called before the first frame update
    void Start()
    {
        spawn = transform.position;
      //  lavaquimonteparla = lava.GetComponent<lavaquimonte>(); 
      //  lavaquimonteparle = lava.GetComponent<levierlava>(); 
    }

    void Update(){
        oui();
    }

    void OnTriggerEnter2D(Collider2D truc) {
        if (truc.tag == "Kill" || truc.tag == "boulet") {
            transform.position = spawn;
        }
     //   if (truc.tag == "Lava") { 
           // transform.position = spawn;
            //levierlava.reset();
           // lavaquimonteparla.restart();
       // }
        if (truc.tag == "CheckPoint") {
            spawn = transform.position;
            checkpointsound.Play();
        }
    }

    void oui(){
        if(Input.GetKeyDown(KeyCode.A)) {
        transform.position = spawn;
     }
     }
     
}