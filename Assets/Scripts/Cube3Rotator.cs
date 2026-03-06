using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cube3Rotator : MonoBehaviour
{
    public Text Cube3Rotation;
    public string position = "";

    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, 1), 1);    

        if(this.Cube3Rotation != null )
        {
            position = string.Format("R:<{3:F2},{4:F2},{5:F2}>",
            this.transform.localPosition.x,
            this.transform.localPosition.y,
            this.transform.localPosition.z,
            this.transform.localEulerAngles.x,
            this.transform.localEulerAngles.y,
            this.transform.localEulerAngles.z);

            this.Cube3Rotation.text = position;
        }
    }
}
