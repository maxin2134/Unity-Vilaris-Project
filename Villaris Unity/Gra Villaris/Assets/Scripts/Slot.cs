using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private Ekwipunek ekwipunek;

    public int NumerButtona;
    public int zero = 0;
    public int pierwszy;
    private int doUsuniecaSlot = -1;
    private int doUsunieciaPotion;

    //private Slider slider;
    PasekZycia pz;
    string nazwa;

    static public int numerPotki = -1;
    static public int[] numerSlot;

    private void Start()
    {
        ekwipunek = GameObject.FindGameObjectWithTag("Player").GetComponent<Ekwipunek>();
        pz = GameObject.Find("pasek_zdrowia").GetComponent<PasekZycia>();
    }

    private void Update()
    {
        //dodawanie itemów do ekwpipunku w miejscu ununiętego
        if (transform.childCount <= 0)
            ekwipunek.isFull[NumerButtona] = false;
    }

    public void DropItem()
    {
        // Tablica potionow
        GameObject[] cm = GameObject.FindGameObjectsWithTag("cm");
        // tablica numerow slotow o wielkosci naszej tablicy potek
        numerSlot = new int[cm.Length];

        //przejdz kazdy element tablicy potek i przypisz do naszej tablicy slotow kazdej potki numer slota
        for (int i = 0; i < cm.Length; i++){
            numerSlot[i] = cm[i].GetComponent<Numer_Potiona>().wewNumerSlota;
        }

        // sprawdz czy numer buttona jest taki sam jak numer w tablicy slot
        for (int i = 0; i < numerSlot.Length; i++){
            // gdy znajdziesz wyjdz z petli
            if (numerSlot[i] == NumerButtona){
                doUsuniecaSlot = numerSlot[i];
                break;
            }
        }

        // przejdz cala tablice potek w poszukiwaniu tej ktora trzeba usunac
        for (int i = 0; i < cm.Length; i++){
            // do zmiennej przypisz numer slota potki
            doUsunieciaPotion = cm[i].GetComponent<Numer_Potiona>().wewNumerSlota;

            // do zmiennej przypisz numer potka
            pierwszy = cm[i].GetComponent<Numer_Potiona>().liczba;

            // sprawdz czy numerslota jest taki sam jak numer slota potki
            if (doUsuniecaSlot == doUsunieciaPotion){
                nazwa = cm[i].ToString();
                //if (nazwa.Equals("CM Button(Clone)"))
                    pz.Heal(20);
                Destroy(cm[i]);
                break;
            }

            if (zero == pierwszy) { }
            else{
                Numer_Potiona.iloscDown();
                cm[i].GetComponent<Numer_Potiona>().LiczbaDown();
            }
        }
    }
}
