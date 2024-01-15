using UnityEngine;

namespace Oculus.Interaction
{
    public class ModifiedGrabbable : Grabbable
    {
        // You can add additional variables or methods specific to ModifiedGrabbable if needed
        public GameObject inFrontObject;
        protected override void UpdateTransform()
        {
            // Add your modifications to the UpdateTransform function here
            // You can call the base implementation using base.UpdateTransform() if needed
            // Or completely override the behavior

            // Example modification: Rotate the object during transform
            if (_activeTransformer == null)
            {
                return;
            }
            if (ColliderList.colliders.Contains(inFrontObject))
            {
                
                OVRInput.SetControllerVibration(10, 10);
            }
            else
            {
                _activeTransformer.UpdateTransform();
            }


            // Call the base implementation if needed
            //base.UpdateTransform();
        }

        // Add any additional methods or overrides as needed
    }
}
