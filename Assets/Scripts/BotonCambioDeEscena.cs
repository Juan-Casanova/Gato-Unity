using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCambioDeEscena : MonoBehaviour
{
    //Cerrar aplicacion
    public void BotonSalir(){
        Application.Quit();
    }

    //inicia la nueva escena
    public void BotonPlay(){
        SceneManager.LoadScene("Juego");
    }
}