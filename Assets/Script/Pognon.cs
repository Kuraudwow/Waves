using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pognon : MonoBehaviour
{
 
    public int monnaie;
    public TMP_Text monText;

    [SerializeField] private AudioSource coinSound;

    void Start() {
        monText.text = monnaie.ToString();
    }




    void OnTriggerEnter2D(Collider2D truc)
    {
        if (truc.tag =="Coin") {
            coinSound.Play();
            monnaie++;
            monText.text = monnaie.ToString();
            Destroy(truc.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}