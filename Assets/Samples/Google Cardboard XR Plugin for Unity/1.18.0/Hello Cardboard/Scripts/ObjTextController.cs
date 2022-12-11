using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjTextController : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI texto;
    public GameObject panel;
    void Start()
    {
        texto.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setText(){
        panel.SetActive(true);
        texto.text = "CATEDRAL DE AREQUIPA \nLa Catedral de Arequipa es considerada uno de los primeros monumentos religiosos del siglo XVII en Arequipa";
    }
    public void OnPointerClick()
    {
        setText();
    }
    public void OnPointerExit()
    {
        panel.SetActive(false);
        texto.text = "";
    }
}
