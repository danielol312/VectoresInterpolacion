using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MrVector
{
    // Start is called before the first frame update
    /// <summary>
    /// My 2D Vector Class
    /// </summary>
    public float x, y;
    public MrVector(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public MrVector suma(MrVector a)
    {
        return new MrVector(a.x + x, a.y + y);
    }
    public MrVector resta(MrVector a)
    {
        return new MrVector(x - a.x, y - a.y);
    }

    public MrVector multiplicacion(float b)
    {
        return new MrVector(b * x, b * y);
    }

    //public MrVector Lerp(MrVector a, MrVector b)
    //{

    //}


    //public MrVector magnitud (MrVector c)
    //{
    //    return new MrVector(x*x)+(y*y) = Mathf.Sqrt(c);

    //}

    //public MrVector Normalizar (MrVector n)
    //{
    //    return new MrVector();
    //}

    public void Draw()
    {
        var startVectorUnity = new Vector3(0, 0, 0);
        var endVectorUnity = new Vector3(x, y, 0);
        Debug.DrawLine(startVectorUnity, endVectorUnity);
    }

    public void Draw(MrVector newOrign)
    {
        var startVectorUnity = new Vector3(newOrign.x, newOrign.y, 0);
        var endVectorUnity = new Vector3(newOrign.x + x, newOrign.y + y, 0);
        Debug.DrawLine(startVectorUnity, endVectorUnity);
    }

    public override string ToString()
    {
        return ("(" + x + "," + y + ")");
    }

    public MrVector normalizar()
    {

        return new MrVector(x / magnitud(), y / magnitud());
    }

    public float magnitud()
    {
        return Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
    }
    

    public MrVector Lerp(MrVector a, MrVector b, float t)
    {
        MrVector c = b.resta(a);
        c = c.multiplicacion(t);
        MrVector result = a.suma(c);
        return result;
    }

    public static MrVector operator + (MrVector a, MrVector b)
    {
        return new MrVector(a.x + b.x, a.y + b.y);
    }
    public static MrVector operator - (MrVector a, MrVector b)
    {
        return new MrVector(a.x - b.x, a.y - b.y);
    }
    public static MrVector operator *(MrVector a, float b)
    {
        return new MrVector(a.x*b, a.y*b);
    }


    // public MrVector Draw2()
    //{
    //   // Debug.DrawLine(Vector1 start, Vector2 end)
    //}
}
