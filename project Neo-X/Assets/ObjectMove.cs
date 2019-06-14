
using UnityEngine;

public class ObjectMove : MonoBehaviour
{

    public GameObject trigger;
    public GameObject painting;

    Animator PaintMove;

    // Start is called before the first frame update
    void Start()
    {
        PaintMove = painting.GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                MovePaint(true);
            }
        }
    }
    private void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            MovePaint(false);
        }
    }
    void MovePaint(bool state)
    {
        PaintMove.SetBool("slide", state);
    }
}
