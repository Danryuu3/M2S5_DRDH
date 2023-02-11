using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class General : MonoBehaviour
{

    public int puntos;
    public TextMeshProUGUI puntaje;
    public TextMeshProUGUI puntaje2;
    public GameObject[] pelotas;
    public GameObject[] botones;
    public GameObject panel;
    int count = 0;


    public void Punt (int numero)
    {
        puntos += numero;
        puntaje.text = "Score: " + puntos.ToString();
        pelotas[count].SetActive(true);
        botones[count].SetActive(false);
        count++;
        botones[count].SetActive(true);
        pelotas[count].SetActive(true);
       

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 5)
        {
            Destroy(pelotas[4]);
            panel.SetActive(true);
            puntaje2.gameObject.SetActive(true);
            puntaje2.text = "Conseguiste " + puntos.ToString() + " puntos";
        }
    }
}
