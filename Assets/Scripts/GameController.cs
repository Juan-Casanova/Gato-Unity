using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool Jugador1=false;
    public bool Jugador2=false;
    public int ran;
    private int[,] tablero;
    public int currentPlayer;
    // Start is called before the first frame update
    void Start()
    {
        //Se genera random para elegir jugador
        ran=Random.Range(1,99);
        //Determina jugador 1 o 2 de acuerdo a si es par o non
        if(ran%2==0){
            ran=0;
            Jugador2=true;
        }
        else{
            ran=1;
            Jugador1=true;
        }
        Debug.Log(ran);
        Debug.Log(Jugador1);
        Debug.Log(Jugador2);
        tablero = new int[3,3];
        InicializarTablero();
        currentPlayer = 1;
    }

     private void InicializarTablero()
    {
        for (int i=0; i<3;i++)
        {
            for (int j=0;j<3;j++)
            {
                tablero[i,j] = 0;
            }
        }
    }
    public void PressButton(int _numButton)
    {
        switch(_numButton)
        {
            case 1:
                tablero[0, 0] = currentPlayer;
                break;
            case 2:
                tablero[0, 1] = currentPlayer;
                break;
            case 3:
                tablero[0, 2] = currentPlayer;
                break;
            case 4:
                tablero[1, 0] = currentPlayer;
                break;
            case 5:
                tablero[1, 1] = currentPlayer;
                break;
            case 6:
                tablero[1, 2] = currentPlayer;
                break;
            case 7:
                tablero[2, 0] = currentPlayer;
                break;
            case 8:
                tablero[2, 1] = currentPlayer;
                break;
            case 9:
                tablero[2, 2] = currentPlayer;
                break;
        }
        changeCurrentPlayer();
    }

    private void changeCurrentPlayer()
    {
        if (currentPlayer==1)
        {
            currentPlayer = 2;
        }
        else
        {
            currentPlayer = 1;
        }
    }
}