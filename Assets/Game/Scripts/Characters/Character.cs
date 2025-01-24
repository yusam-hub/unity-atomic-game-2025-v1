using System.Collections;
using UnityEngine;

namespace Game
{
    public class Character : MonoBehaviour, ICharacter
    {
        [SerializeField]
        private Vector3 destination;

        [SerializeField]
        private float stoppingDistance = 0.1f;
        
        [SerializeField]
        private float speed = 2.5f;
        
        private Coroutine _coroutine;
        

        private Vector3 _lastDirection;

        public bool IsMoving()
        {
            return this._coroutine != null || this._lastDirection != Vector3.zero;
        }
        
        public void Move(Vector3 direction, float deltaTime)
        {
            this._lastDirection = direction;

            if (this._lastDirection != Vector3.zero)
            {
                if (_coroutine != null)
                {
                    this.StopCoroutine(_coroutine);
                    _coroutine = null;
                }
                this.transform.position += this._lastDirection * (deltaTime * this.speed);
                this.transform.rotation = Quaternion.LookRotation(this._lastDirection, Vector3.up);
            }
        }

        public Vector3 GetPosition()
        {
            return this.transform.position;
        }

        public void SetStoppingDistance(float stoppingDistance)
        {
            this.stoppingDistance = stoppingDistance;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        public void MoveTo(Vector3 destination)
        {
            if (_coroutine != null)
            {
                this.StopCoroutine(_coroutine);
            }

            this.destination = destination;
            this._coroutine = this.StartCoroutine(this.MoveToRoutine());
        }

        private IEnumerator MoveToRoutine()
        {
            WaitForFixedUpdate yield = new WaitForFixedUpdate();

            while (true)
            {
                Vector3 currentPosition = this.transform.position;
                Vector3 vector = this.destination - currentPosition;
                vector.y = 0;

                if (vector.sqrMagnitude <= this.stoppingDistance * this.stoppingDistance)
                {
                    this.transform.position = this.destination;
                    _coroutine = null;
                    yield break;
                }

                Vector3 direction = vector.normalized;
                this.transform.position += direction * this.speed * Time.fixedDeltaTime;
                this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
                yield return yield;
            }
        }
    }
}