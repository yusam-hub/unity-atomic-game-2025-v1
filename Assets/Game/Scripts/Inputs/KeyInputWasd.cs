using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Game
{
    public sealed class KeyInputWasd : DirectionVector3
    {
        private readonly KeyCode _keyInputUp = KeyCode.W;        
        private readonly KeyCode _keyInputDown = KeyCode.S;   
        private readonly KeyCode _keyInputLeft = KeyCode.A;   
        private readonly KeyCode _keyInputRight = KeyCode.D;
        
        public override Vector3 GetDirection()
        {
            Vector3 direction = Vector3.zero;
            
            if (Input.GetKey(this._keyInputUp))
            {
                direction.z = 1;
            }
            else if (Input.GetKey(this._keyInputDown))
            {
                direction.z = -1;
            }

            if (Input.GetKey(this._keyInputLeft))
            {
                direction.x = -1;
            }
            else if (Input.GetKey(this._keyInputRight))
            {
                direction.x = 1;
            }

            return direction;
        }
    }
}

