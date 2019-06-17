
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField]
    private GameObject key;

    public bool rota;
    public float posX;
    public float posZ;
    private void Start()
    {
        key.SetActive(false);
        posX = gameObject.transform.position.x;
        posZ = gameObject.transform.position.z;
    }
    private void Update()
    {
        if (rota == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                print("sss");
                transform.position= new Vector3(posX, -0.05f, posZ);
                key.SetActive(true);
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        print("AAAAAA");
        if (other.attachedRigidbody)
        {
            rota = true;
        }


    }

    void OnTriggerExit(Collider other)
    {
        rota = false;
        Debug.Log("leaving");
    }
    private void OnGUI()
    {
        if (rota == true)
        {

            GUI.Box(new Rect(0, 0, Screen.width / 8f, Screen.height / 40f), "Press F to Move");
        }
    }
}

