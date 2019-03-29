using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    Rigidbody fizik;
    public int hiz,toplanacak_obje_sayisi;
    public Text sayactext,oyunbittitext;
    int sayac=0;
    void Start () {
        fizik = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        Debug.Log(x + " -- " + y);
        Vector3 vec = new Vector3(x, 0, y);

        fizik.AddForce(vec*hiz);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cubes for Gather")
        {
            Destroy(other.gameObject);
            sayac++;
            sayactext.text = "For Win <= " + sayac + "/" + toplanacak_obje_sayisi;
            if (sayac == toplanacak_obje_sayisi)
            {
                oyunbittitext.text = "COMPLETE";
            }
        }
        
    }
}
