using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveX : MonoBehaviour
{
    public delegate void MoveX(float val);
    public event MoveX OnMoveX;
    // Start is called before the first frame update
    private void OnMouseDrag()
    {
        if (Input.GetAxis("Mouse X") < 0)
        {
            OnMoveX(-1f);
        }

        if (Input.GetAxis("Mouse X") > 0)
        {
            OnMoveX(1f);
        }
    }
}
