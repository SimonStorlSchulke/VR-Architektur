using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
    //-------------------------------------------------------------------------
    public class LinearBlendshape2 : MonoBehaviour
    {
        public LinearMapping linearMapping;
        public SkinnedMeshRenderer skinnedMesh;

        private float lastValue;


        //-------------------------------------------------
        void Awake()
        {
            if (skinnedMesh == null)
            {
                skinnedMesh = GetComponent<SkinnedMeshRenderer>();
            }

            if (linearMapping == null)
            {
                linearMapping = GetComponent<LinearMapping>();
            }
        }


        //-------------------------------------------------
        void Update()
        {
            float value = linearMapping.value;

            //No need to set the blend if our value hasn't changed.
            if (value != lastValue)
            {
                float blendValue = Util.RemapNumberClamped(value, 0f, 1f, 1f, 100f);
                
                skinnedMesh.SetBlendShapeWeight(1, blendValue);
                
            }

            lastValue = value;
        }
    }
}
