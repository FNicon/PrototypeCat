using System;
using UnityEngine;

namespace chera.test
{
    public class Draggable : MonoBehaviour
    {
        private Vector3 lastPosition;
        enum InteractionPhase
        {
            firstInteraction,
            isCurrentlyBeingInteracted,
            endOfInteraction,
            notBeingInteracted
        }
        InteractionPhase phase;

        void Start()
        {
            lastPosition = transform.localPosition;
        }

        void Update()
        {
            if (isBeingInteracted())
            {
                updateInteractionPhase();
                switch (phase)
                {
                    case InteractionPhase.firstInteraction:
                        lastPosition = this.transform.position;
                        break;
                    case InteractionPhase.isCurrentlyBeingInteracted:
						Vector3 pointerOnWorldPosition = Camera.current.ScreenToWorldPoint(Input.touches[0].position);
                        moveTowardsAPoint(pointerOnWorldPosition, 1);
                        break;
                    case InteractionPhase.endOfInteraction:
                        resolveEndOfInteraction();
                        break;
                }
            }
            else
            {
                moveTowardsAPoint(lastPosition, 0.5f);
            }
        }

        private void moveTowardsAPoint(Vector2 pointerPosition, float percentageHowFar)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition, pointerPosition,
                Vector3.Distance(transform.position, pointerPosition) * percentageHowFar
            ) + new Vector3(0, 0, transform.localPosition.z);
        }

        private void resolveEndOfInteraction()
        {
            phase = InteractionPhase.notBeingInteracted;
        }

        private void updateInteractionPhase()
        {
            //assume isBeingInteracted is true
            Touch touch = Input.touches[0];
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    phase = InteractionPhase.firstInteraction;
                    break;
                case TouchPhase.Moved:
                case TouchPhase.Stationary:
                    phase = InteractionPhase.isCurrentlyBeingInteracted;
                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    phase = InteractionPhase.endOfInteraction;
                    break;
            }
        }

        private bool isBeingInteracted()
        {
            return Input.touchCount > 0;
        }
    }
}