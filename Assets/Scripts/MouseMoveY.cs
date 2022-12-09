using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveY : MonoBehaviour
{
    public delegate void MoveY(float val);
    public event MoveY OnMoveY;
    // Start is called before the first frame update
    private void OnMouseDrag()
    {
        if (Input.GetAxis("Mouse Y") < 0)
        {
            OnMoveY(-1f);
        }

        if (Input.GetAxis("Mouse Y") > 0)
        {
            OnMoveY(1f);
        }
    }
}
