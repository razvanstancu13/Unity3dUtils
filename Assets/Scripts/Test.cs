using ExtensionMethods;
using UnityEngine;

namespace VectorExtensions
{
    public class Test : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            var v2 = new Vector2(4.675f, 12.9380f);
            var v3 = new Vector3(2.403f, 5.0392f, 7.8594f);
            var v4 = new Vector4(17.556f, 28.455f, 1.9890f, 3.3372f);

            Debug.Log("V2 : " + v2.ToString());
            Debug.Log("V3 : " + v3.ToString());
            Debug.Log("V4 : " + v4.ToString());

            Debug.Log("V2(yx) : " + v2.Swizzle("yx").ToString());
            Debug.Log("V2(x1x0) : " + v2.Swizzle("x1x0").ToString());
            Debug.Log("V2(yyx) : " + v2.Swizzle("yyx").ToString());

            Debug.Log("V3(zxy) : " + v3.Swizzle("zxy").ToString());
            Debug.Log("V3(xyxz) : " + v3.Swizzle("xyxz").ToString());
            Debug.Log("V3(xz) : " + v3.Swizzle("xz").ToString());

            Debug.Log("V4(1xwz) : " + v4.Swizzle("1xwz").ToString());
            Debug.Log("V4(zwx) : " + v4.Swizzle("zwx").ToString());
            Debug.Log("V4(yy) : " + v4.Swizzle("yy").ToString());
        }
    }
}

