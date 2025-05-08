using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palabraSecreta : MonoBehaviour
{
    string palabraCorrecta = "domingo";
    public string palabra;
    // Start is called before the first frame update
    void Start()
    {
        if (palabra != palabraCorrecta)
        {
            Debug.Log("Palabra incorrecta");
            return;
        }
        else if (palabra == palabraCorrecta)
        {
            Debug.Log("Has adivinado la palabra");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
