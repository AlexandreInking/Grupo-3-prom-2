using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModSystem : MonoBehaviour
{
    public int intMoney = 100;
    public int[] prices; // Precios de productos
    public bool bolUse = true;

    // Controls
    public KeyCode leftButton; // left
    public KeyCode rightButton; // right
    public KeyCode enterButton; // enter

    // UI
    public TextMeshProUGUI strMoney;
    public GameObject imgCartel; // Cartel
    public GameObject selector;
    public int selPos = 1; // Posicion

    // Start is called before the first frame update
    void Awake() {
        prices = new int[3]; // Precios
        prices[0] = 20; // Pocion
        prices[1] = 50; // Espada
        prices[2] = 10; // Hoja de mana

        strMoney.text = intMoney.ToString();
    }
}
