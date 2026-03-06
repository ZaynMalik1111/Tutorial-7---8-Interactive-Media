using UnityEngine;

public class CreatePrimitivesFromInput : MonoBehaviour
{
    private GameObject Cube1;

    private GameObject Cube2;

    private GameObject Cube3;

    private bool PRIMITIVES_CREATED;

    void Start()
    {
        this.PRIMITIVES_CREATED = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            this.CreateMyPrimitives();
        }

        if (PRIMITIVES_CREATED)
        {
            this.Cube1.transform.Rotate(new Vector3(0, 0, 1), 1);
            this.Cube2.transform.Rotate(new Vector3(0, 0, 1), 1);
            this.Cube3.transform.Rotate(new Vector3(0, 0, 1), 1);
        }
    }

    void CreateMyPrimitives()
    {
        if (this.Cube1 == null) 
        {
            this.Cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            this.Cube1.transform.localPosition = new Vector3 (0,2,0);
        }

        if (this.Cube2 == null)
        {
            this.Cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            this.Cube2.transform.localPosition = new Vector3(0, 2, 0);
        }

        if (this.Cube3 == null)
        {
            this.Cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            this.Cube3.transform.localPosition = new Vector3(0, 2, 0);
        }
        this.PRIMITIVES_CREATED = true;
    }
}
