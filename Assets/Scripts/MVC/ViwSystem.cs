using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViwSystem : ModSystem
{
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
}
