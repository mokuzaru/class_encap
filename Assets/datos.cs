using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(pedido.vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void colorear(int a){
        if(a < 9){
            Debug.Log("me llamo otro objeto");
        }else{
            Debug.Log("intenta de nuevo");
        }
    }
}
