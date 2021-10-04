using Kuhpik;
using UnityEngine;

public class JointMouseDrag : MonoBehaviour
{
    [SerializeField] private LayerMask layer;
    [SerializeField] private JointMouseDrag other;
    
    private Transform currentHand;
    private bool drag;
    private Rigidbody rb;
    private ConfigurableJoint conf;
    private float zPosition;
    private Vector3 lastposition;
    private bool fall;
    
    
    void Start()
    {
        drag = false;
        rb = GetComponent<Rigidbody>();
        conf = GetComponent<ConfigurableJoint>();
        zPosition = transform.position.z;
        lastposition = transform.position;
        fall = true;
    }

    private void FixedUpdate()
    {
        if (fall)
        {
            CheckState();
        }
    }

    private void OnMouseDown()
    {
        drag = true;
    }

    private void OnMouseUp()
    {
        drag = false;
    }

    public void Falling()
    {
        drag = false;
        if (TryGetComponent(out conf))
        {
            conf.breakForce = 1;
        }
        //conf.breakForce = 0;
        MainFalling();
    }

    private void MainFalling()
    {
        /*rb.isKinematic = false;
        rb.useGravity = true;*/
        transform.parent.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        transform.parent.GetComponent<Collider>().enabled = true;
        transform.SetParent(null);
        // rb.velocity = Vector3.zero;
        drag = false;
        fall = false;
    }

    private void CheckState()
    {
        if (drag)
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000f, layer.value))
            {
                Vector3 pos = hit.point;
                pos.z = zPosition;
                lastposition = pos;
                rb.MovePosition(lastposition);
            }

            if (!TryGetComponent(out conf))
            {
                MainFalling();
                other.Falling();
            }
        }
        else
        {
            rb.MovePosition(lastposition);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name.Contains("Cube"))
        {
            drag = false;
        }
    }
}
