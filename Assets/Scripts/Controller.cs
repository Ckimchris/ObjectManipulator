using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject targetMesh;

    public GameObject rotateX;
    public GameObject rotateY;
    public GameObject rotateZ;
    public GameObject prismX;
    public GameObject prismY;
    public GameObject prismZ;
    public GameObject sphereX;
    public GameObject sphereY;
    public GameObject sphereZ;

    private float xScaleTotal;
    private float yScaleTotal;
    private float zScaleTotal;

    void Start()
    {
        
    }
    private void OnEnable()
    {
        rotateX.GetComponent<MouseMoveY>().OnMoveY += RotateX;
        rotateY.GetComponent<MouseMoveX>().OnMoveX += RotateY;
        rotateZ.GetComponent<MouseMoveX>().OnMoveX += RotateZ;
        prismX.GetComponent<MouseMoveX>().OnMoveX += TranslateX;
        prismY.GetComponent<MouseMoveY>().OnMoveY += TranslateY;
        prismZ.GetComponent<MouseMoveY>().OnMoveY += TranslateZ;
        sphereX.GetComponent<MouseMoveX>().OnMoveX += ScaleX;
        sphereY.GetComponent<MouseMoveY>().OnMoveY += ScaleY;
        sphereZ.GetComponent<MouseMoveY>().OnMoveY += ScaleZ;
    }

    private void OnDisable()
    {
        rotateX.GetComponent<MouseMoveY>().OnMoveY -= RotateX;
        rotateY.GetComponent<MouseMoveX>().OnMoveX -= RotateY;
        rotateZ.GetComponent<MouseMoveX>().OnMoveX -= RotateZ;
        prismX.GetComponent<MouseMoveX>().OnMoveX -= TranslateX;
        prismY.GetComponent<MouseMoveY>().OnMoveY -= TranslateY;
        prismZ.GetComponent<MouseMoveY>().OnMoveY -= TranslateZ;
        sphereX.GetComponent<MouseMoveX>().OnMoveX -= ScaleX;
        sphereY.GetComponent<MouseMoveY>().OnMoveY -= ScaleY;
        sphereZ.GetComponent<MouseMoveY>().OnMoveY -= ScaleZ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateX(float val)
    {
        targetMesh.transform.Rotate(new Vector3(val* 180f, transform.rotation.y, transform.rotation.z) * Time.deltaTime);
    }

    public void RotateY(float val)
    {
        targetMesh.transform.Rotate(new Vector3(transform.rotation.x, val* 180f, transform.rotation.z) * Time.deltaTime);
    }

    public void RotateZ(float val)
    {
        targetMesh.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, val* 180f) * Time.deltaTime);
    }
    public void TranslateX(float val)
    {
        transform.Translate((val * Vector3.right) * Time.deltaTime);
    }

    public void TranslateY(float val)
    {
        transform.Translate((val * Vector3.up) * Time.deltaTime);
    }

    public void TranslateZ(float val)
    {
        transform.Translate((val * Vector3.forward) * Time.deltaTime);
    }

    public void ScaleX(float val)
    {
        xScaleTotal = xScaleTotal + (val * 0.1f);
        xScaleTotal = Mathf.Clamp((xScaleTotal), 0.1f, 1.5f);
        targetMesh.transform.localScale = new Vector3(xScaleTotal, targetMesh.gameObject.transform.localScale.y, targetMesh.gameObject.transform.localScale.z);
    }

    public void ScaleY(float val)
    {
        yScaleTotal = yScaleTotal + (val * 0.1f);
        yScaleTotal = Mathf.Clamp((yScaleTotal), 0.1f, 1.5f);
        targetMesh.transform.localScale = new Vector3(targetMesh.gameObject.transform.localScale.x, yScaleTotal, targetMesh.gameObject.transform.localScale.z);
    }

    public void ScaleZ(float val)
    {
        zScaleTotal = zScaleTotal + (val * 0.1f);
        zScaleTotal = Mathf.Clamp((zScaleTotal), 0.1f, 1.5f);
        targetMesh.transform.localScale = new Vector3(targetMesh.gameObject.transform.localScale.x, targetMesh.gameObject.transform.localScale.y, zScaleTotal);
    }
}