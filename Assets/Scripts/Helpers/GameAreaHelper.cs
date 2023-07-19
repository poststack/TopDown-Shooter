﻿using UnityEngine;

namespace Utility
{
    public static class GameAreaHelper
    {

        private static Camera _camera;
        

        static GameAreaHelper()
        {
            _camera = Camera.main;
        }

        
        public static bool IsInGameplayArea(Transform objectTransform, Bounds objectBounds)
        {
            var camHalfHeight = _camera.orthographicSize;
            var camHalfWidth = camHalfHeight * _camera.aspect;
            var camPos = _camera.transform.position;
            var topBound = camPos.y + camHalfHeight;
            var bottomBound = camPos.y - camHalfHeight;
            var leftBound = camPos.x - camHalfWidth;
            var rightBound = camPos.x + camHalfWidth;

            var objectPos = objectTransform.position;

            return (objectPos.x - objectBounds.extents.x < rightBound)
                && (objectPos.x + objectBounds.extents.x > leftBound)
                && (objectPos.y - objectBounds.extents.y < topBound)
                && (objectPos.y + objectBounds.extents.y > bottomBound);

        }

        public static void BlockInGameplayArea(Transform objectTransform, Bounds objectBounds)
        {
            var camHalfHeight = _camera.orthographicSize;
            var camHalfWidth = camHalfHeight * _camera.aspect;
            var camPos = _camera.transform.position;
            var topBound = camPos.y + camHalfHeight;
            var bottomBound = camPos.y - camHalfHeight;
            var leftBound = camPos.x - camHalfWidth;
            var rightBound = camPos.x + camHalfWidth;

            var objectPos = objectTransform.position;

            objectTransform.position = new Vector3(
                Mathf.Clamp(objectTransform.position.x, leftBound + objectBounds.extents.x, rightBound - objectBounds.extents.x),
                Mathf.Clamp(objectTransform.position.y, bottomBound + objectBounds.extents.y, topBound - objectBounds.extents.y),
                0);

        }

    }
}
