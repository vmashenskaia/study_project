using System;
using UnityEngine;

namespace CameraLogic
{
    public class CameraFollow: MonoBehaviour
    {
        [SerializeField]
        private Transform _following;
        [SerializeField]
        private float _rotationAngleX;
        [SerializeField]
        private float _distance;
        [SerializeField]
        private float _offsetY;

        private void LateUpdate()
        {
            if (_following == null)
                return;

            var rotation = Quaternion.Euler(_rotationAngleX, 0, 0);
            var position = rotation * new Vector3(0, 0, -_distance) + FollowingPointPosition();
            transform.rotation = rotation;
            transform.position = position;
        }

        public void Follow(GameObject followingObject)
        {
            _following = followingObject.transform;
        }

        private Vector3 FollowingPointPosition()
        {
            Vector3 followingPosition = _following.position;
            followingPosition.y += _offsetY;
            return followingPosition;
        }
    }
}