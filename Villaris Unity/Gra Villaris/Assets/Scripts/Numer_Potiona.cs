using UnityEngine;

public class Numer_Potiona : MonoBehaviour
{
    static public int numer = -1;
    static public int numerSlota;

    public int liczba;
    public int wewNumerSlota;

    static public void iloscUP(){
        numer++;
    }

    public void UstawLiczbe(){
        liczba = numer;
    }

    public void LiczbaDown(){
        liczba--;
    }

    static public void iloscDown(){
        numer--;
    }

    static public void ustawSlot(int kwak){
        numerSlota = kwak;
    }

    public void ustawWewSlot(){
        wewNumerSlota = numerSlota;
    }

    private void Start(){
        UstawLiczbe();
        ustawWewSlot();
    }
}
