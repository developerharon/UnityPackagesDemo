using UnityEngine;

namespace Haron
{
    public class RotateCube : MonoBehaviour
    {
        public Vector3 RotateAmount;

        // Start is called before the first frame update
        void Start()
        {
            // This is here for sample purposes
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(RotateAmount);
        }
    }
}