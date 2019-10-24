using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SystemController : MonoBehaviour
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
    void Awake()
    {
        prices = new int[3]; // Precios
        prices[0] = 20; // Pocion
        prices[1] = 50; // Espada
        prices[2] = 10; // Hoja de mana

        strMoney.text = intMoney.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (bolUse) {
            Move();
        }

        strMoney.text = intMoney.ToString();

        if (Input.GetKeyDown(enterButton)) {
            Select();
        }
    }

    void Move() {
        if (Input.GetKeyDown(leftButton) && selPos > 0) {
            selector.transform.position -= new Vector3(33, 0, 0);
            selPos--;
        }

        if (Input.GetKeyDown(rightButton) && selPos < 2) {
            selector.transform.position += new Vector3(33, 0, 0);
            selPos++;
        }
    }

    void Select() {
        int price = 0;
        price = prices[selPos];
        Comprar(price);
    }

    void Comprar(int price) {
        if (intMoney - price >= 0) {
            intMoney -= price; // Disminuir
        } else {
            imgCartel.SetActive(true); // Cartel
            bolUse = false;
        }
    }
}
