using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrTest : MonoBehaviour
{

    [SerializeField] MrVector Vector1 = new MrVector(-1, 1);
    [SerializeField] MrVector Vector2 = new MrVector(1, 1);
    [SerializeField][Range(0, 1)] float Range = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        //MrVector obj = new MrVector(3, 2);
        //Vector1.suma(Vector2);
        
        //obj.Mrvector
        ////MrVector result = Vector1.suma(Vector2);
        //new MrVector= var Pruebasvector;
        //PruebasVector.suma();

    }

    private void Update()
    {
        MrVector resta = Vector2.resta(Vector1).multiplicacion(Range);
        MrVector lerp = Vector1.Lerp(Vector1, Vector2, Range);
        resta.Draw();
        resta.Draw(Vector1);
        Vector1.Draw();   
        Vector2.Draw();
        lerp.Draw();
        //Vector1.Draw();
        //Vector2.Draw();
        ////obj.Draw();
        //Debug.DrawLine(this.transform.position, Vector1+Vector2 )
    }
}
