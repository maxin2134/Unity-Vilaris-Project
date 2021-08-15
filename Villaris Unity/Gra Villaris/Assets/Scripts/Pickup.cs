using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Ekwipunek ekwipunek;
    public GameObject itemButton;

    private void Start(){
        ekwipunek = GameObject.FindGameObjectWithTag("Player").GetComponent<Ekwipunek>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            for(int i = 0; i < ekwipunek.slots.Length; i++){
                if(ekwipunek.isFull[i] == false){
                    ekwipunek.isFull[i] = true;
                    Instantiate(itemButton, ekwipunek.slots[i].transform, false);
                    Numer_Potiona.iloscUP();
                    Numer_Potiona.ustawSlot(i);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
