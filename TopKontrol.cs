using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public int hiz;
    public Rigidbody fizik;
    public int puan;
    public int objeSayisi;
    public Text puanText;
    public Text oyunBittiText;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        
    }

   
    void Update()
    {
   
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 vektor = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vektor * hiz);

        Debug.Log(transform.position);
    }
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        puan++;
        puanText.text = "Puan: " + puan; 

      
        
        if(puan == objeSayisi)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
    }
}
