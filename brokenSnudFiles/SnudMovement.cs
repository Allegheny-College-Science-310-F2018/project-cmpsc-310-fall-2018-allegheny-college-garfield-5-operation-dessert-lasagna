using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnudMovement : MonoBehaviour {

  void Update () {

    bool doubleRaycastDown (TerrainMovementRayProperties movementRay, float rayLength, out RaycastHit leftHitInfo, out RaycastHit rightHitInfo) {
    Vector3 transformUp = transform.up;
    Vector3 transformRight = transform.right;
    Ray leftRay = new Ray(transform.position + movementRay.originOffsetY * transformUp + movementRay.distanceFromCenter * transformRight, -transformUp);
    Ray rightRay = new Ray(transform.position + movementRay.originOffsetY * transformUp - movementRay.distanceFromCenter * transformRight, -transformUp);

    return Physics.Raycast(leftRay, out leftHitInfo, rayLength, DefaultTerrainLayerMask) && Physics.Raycast(rightRay, out rightHitInfo, rayLength, DefaultTerrainLayerMask);
    }

  void positionOnTerrain (RaycastHit leftHitInfo, RaycastHit rightHitInfo, float maxRotationDegrees, float positionOffsetY) {
    Vector3 averageNormal = (leftHitInfo.normal + rightHitInfo.normal) / 2;
    Vector3 averagePoint = (leftHitInfo.point + rightHitInfo.point) / 2;

    Quaternion targetRotation = Quaternion.FromToRotation(Vector3.up, averageNormal);
    Quaternion finalRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, maxRotationDegrees);
    transform.rotation = Quaternion.Euler(0, 0, finalRotation.eulerAngles.z);

    transform.position = averagePoint + transform.up * positionOffsetY;
    }

    if (rigidbody.velocity.sqrMagnitude > 0) {
      //if moving left
      if (MathUtilities.VectorSimilarity(rigidbody.velocity, selfTransform.right) > 0) {
          RaycastHit overrideLeftHitInfo;
          Ray overrideLeftRay = new Ray(transform.position + horizontalRayProperties.originOffsetY * selfTransform.up, selfTransform.right);
          if (Physics.Raycast(overrideLeftRay, out overrideLeftHitInfo, horizontalRayProperties.attachedRayLength, DefaultTerrainLayerMask)) {
              leftHitInfo = overrideLeftHitInfo;
            }
          }
          //if moving right
          else {
            RaycastHit overrideRightHitInfo;
            Ray overrideRightRay = new Ray(transform.position + horizontalRayProperties.originOffsetY * selfTransform.up, -selfTransform.right);
            if (Physics.Raycast(overrideRightRay, out overrideRightHitInfo, horizontalRayProperties.attachedRayLength, DefaultTerrainLayerMask)) {
              rightHitInfo = overrideRightHitInfo;
            }
          }
      }
  }
}
