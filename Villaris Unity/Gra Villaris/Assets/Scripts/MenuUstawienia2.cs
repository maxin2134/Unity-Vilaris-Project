using UnityEngine;
using UnityEngine.UI;

public class MenuUstawienia2 : MonoBehaviour
{
    public Dropdown dropdown;

    public void SetFullScreen(){
        if(dropdown.value == 0)
            Screen.fullScreen = true;
        else
            Screen.fullScreen = false;
    }
}
