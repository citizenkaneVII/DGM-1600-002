using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void Start () {
         Camera main;
     }



    void FixedUpdate()
    {
        //var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        //var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var y = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //transform.Rotate(0, x, 0);
        //transform.Translate(0, x, 0);
        transform.Translate(y, 0, 0);
        transform.Translate(0, 0, z);

        /*float mouseInput = Input.GetAxis("Mouse X");
         Vector3 lookhere = new Vector3(0,mouseInput,0);
         transform.Rotate(lookhere); */

         float x = 5 * Input.GetAxis ("Mouse X");
         float y = 5 * -Input.GetAxis ("Mouse Y");
         Camera.main.transform.Rotate (x, y, 0);
    }
}