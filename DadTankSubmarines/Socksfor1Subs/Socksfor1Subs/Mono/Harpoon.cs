using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class Harpoon : MonoBehaviour
    {
        public Tank tank;
        public Rigidbody rb;
        public WorldForces worldForces;
        public Transform chainAttach;
        public Collider collider;

        public float velocity = 38f;
        public float reelInVelocity = 50f;
        public float reelInCreatureVelocity = 30f;
        public float rotateToTargetAnglesPerSecond = 400f;
        public float fallDownAnglesPerSecond = 50f;
        public float reelInAnglesPerSecond = 200f;
        public float homeDelay = 0.3f;
        public float harpoonMaxReelInTime = 15f;
        public float reelInDetachDistance = 10f;

        public Vector3 targetPosition;
        public Transform targetTransform;

        private Attachment _currentAttachment;
        private float _timeCreated;
        private bool _breachedSurface;
        private bool _reelingIn;
        private float _timeReelInStart;

        private float _chainLimit = 150f;
        private float _chainLimitWhileAttached = 500f;

        private LineRenderer _lineRenderer;

        private FMODAsset _attachSound = Helpers.GetFmodAsset("TankTorpedoExplosionClose");

        private Vector3 TargetPosition
        {
            get
            {
                if (_reelingIn)
                {
                    return tank.weapons.barrelEnd.transform.position;
                }
                if (targetTransform != null)
                {
                    return targetTransform.position;
                }
                else
                {
                    return targetPosition;
                }
            }
        }

        private float ChainLimit
        {
            get
            {
                if (AttachedToAnything)
                {
                    return _chainLimitWhileAttached;
                }
                return _chainLimit;
            }
        }


        public bool AttachedToAnything
        {
            get
            {
                return _currentAttachment != null && _currentAttachment.IsValid;
            }
        }

        public bool AttachedToCreature
        {
            get
            {
                if (AttachedToAnything)
                {
                    return _currentAttachment.type == AttachmentType.Creature && _currentAttachment.attachedRigidbody != null;
                }
                return false;
            }
        }

        public bool AttachedToObject
        {
            get
            {
                if (AttachedToAnything)
                {
                    return _currentAttachment.type == AttachmentType.Object || _currentAttachment.type == AttachmentType.Creature;
                }
                return false;
            }
        }

        public bool AttachedToSomethingMoving
        {
            get
            {
                return AttachedToObject && _currentAttachment.attachedRigidbody != null;
            }
        }

        public bool DraggingObjectIn
        {
            get
            {
                return BeingReeledIn && AttachedToObject && _currentAttachment.attachedRigidbody != null && !_currentAttachment.tooHeavyToPull;
            }
        }

        public Rigidbody PulledInRigidbody
        {
            get
            {
                if (!AttachedToObject)
                {
                    return null;
                }
                return _currentAttachment.attachedRigidbody;
            }
        }

        public bool BeingReeledIn
        {
            get
            {
                return _reelingIn;
            }
        }

        private void Start()
        {
            _timeCreated = Time.time;
            rb.velocity = transform.forward * velocity;

            _lineRenderer = gameObject.AddComponent<LineRenderer>();
            _lineRenderer.useWorldSpace = true;
            _lineRenderer.material = new Material(Shader.Find("MarmosetUBER"));
            _lineRenderer.material.SetColor("_Color", Color.black);
            _lineRenderer.positionCount = 2;
            _lineRenderer.widthMultiplier = 0.1f;
            UpdateLineRenderer();
        }

        private void Update()
        {
            PrimaryUpdateLogic();
            UpdateLineRenderer();
            CheckDistances();
        }

        private void UpdateLineRenderer()
        {
            _lineRenderer.SetPositions(new Vector3[] { tank.weapons.barrelEnd.position, chainAttach.position });
        }

        private void CheckDistances()
        {
            if (!BeingReeledIn && Vector3.Distance(tank.weapons.barrelEnd.position, chainAttach.position) > ChainLimit)
            {
                CallBack();
            }
            if (BeingReeledIn)
            {
                if (Vector3.Distance(tank.weapons.barrelEnd.position, chainAttach.position) < reelInDetachDistance)
                {
                    Detach();
                }
            }
        }

        private void PrimaryUpdateLogic()
        {
            if (tank == null || (_reelingIn && Time.time > _timeReelInStart + harpoonMaxReelInTime))
            {
                Destroy(gameObject);
                return;
            }
            if (AttachedToObject && _currentAttachment.attachedObject == null)
            {
                Detach();
                return;
            }
            if (AttachedToAnything)
            {
                if (DraggingObjectIn)
                {
                    rb.isKinematic = false;
                    UpdateReelIn();
                    DragBackObject();
                }
                else if (BeingReeledIn)
                {
                    rb.isKinematic = true;
                }
                else
                {
                    rb.isKinematic = true;
                    UpdatePositionWhileAttached();
                    UpdateReelIn();
                }
                return;
            }
            else
            {
                rb.isKinematic = false;
            }
            if (worldForces.IsAboveWater() && !_reelingIn)
            {
                FallToDownRotation();
                _breachedSurface = true;
            }
            if (_breachedSurface && !_reelingIn)
            {
                return;
            }
            if (_reelingIn)
            {
                UpdateReelIn();
            }
            else
            {
                if (Time.time > _timeCreated + homeDelay)
                {
                    rb.velocity = transform.forward * velocity;
                    HomeOnTarget();
                }
            }
        }

        private void UpdatePositionWhileAttached()
        {
            if (_currentAttachment.TryGetAttachedPosition(out Vector3 attachPos))
            {
                transform.position = attachPos;
            }
            if (_currentAttachment.TryGetAttachedDirection(out Vector3 attachDir))
            {
                transform.forward = attachDir;
            }
            else
            {
                transform.forward = tank.weapons.barrelEnd.transform.forward;
            }
        }

        private void DragBackObject()
        {
            _currentAttachment.attachedRigidbody.velocity = rb.velocity;
        }

        private void HomeOnTarget()
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation((TargetPosition - transform.position).normalized), Time.deltaTime * rotateToTargetAnglesPerSecond);
        }

        private void UpdateReelIn()
        {
            var directionToTarget = (tank.weapons.barrelEnd.position - transform.position).normalized;
            rb.velocity = directionToTarget * (AttachedToCreature ? reelInCreatureVelocity : reelInVelocity);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(-(tank.weapons.barrelEnd.position - chainAttach.position).normalized), Time.deltaTime * reelInAnglesPerSecond);
            if (Vector3.Distance(transform.position, tank.weapons.barrelEnd.position) < 1f)
            {
                Destroy(gameObject);
            }
        }

        private void FallToDownRotation()
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(Vector3.down), Time.deltaTime * fallDownAnglesPerSecond);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (_reelingIn)
            {
                return;
            }
            var hitGo = collision.gameObject;
            var isTerrain = hitGo.layer == LayerID.TerrainCollider;
            if (isTerrain)
            {
                CreateNewAttachment(new Attachment(transform.position, transform.forward));
            }
            var creature = hitGo.GetComponentInParent<Creature>();
            if (creature != null)
            {
                hitGo = creature.gameObject;
            }
            CreateNewAttachment(new Attachment(hitGo, transform.position, transform.forward, creature));
            collider.enabled = false;
        }

        public void CreateNewAttachment(Attachment attachment)
        {
            _currentAttachment = attachment;
            Utils.PlayFMODAsset(_attachSound, transform.position);
        }

        public void CallBack()
        {
            ReelIn();
        }

        public void Detach()
        {
            _currentAttachment = null;
            collider.enabled = true;
        }

        public void ReelIn()
        {
            _reelingIn = true;
            _timeReelInStart = Time.time;
        }

        public void CancelReelIn()
        {
            _reelingIn = false;
        }

        public class Attachment
        {
            public AttachmentType type;
            public Vector3 terrainPoint;
            public Vector3 terrainAttachDirection;
            public GameObject attachedObject;
            public Rigidbody attachedRigidbody;
            public Vector3 localPointOnObject;
            public Vector3 localForwardOnObject;
            public bool tooHeavyToPull;

            public Attachment(Vector3 pointOnTerrain, Vector3 attachDirection)
            {
                type = AttachmentType.Terrain;
                terrainPoint = pointOnTerrain;
                terrainAttachDirection = attachDirection;
            }

            public Attachment(GameObject attachedObject, Vector3 worldPosition, Vector3 currentDirection, Creature creatureComponent)
            {
                if (attachedObject == null)
                {
                    type = AttachmentType.None;
                    return;
                }
                this.attachedObject = attachedObject;
                bool isCreature = creatureComponent != null;
                type = isCreature ? AttachmentType.Creature : AttachmentType.Object;
                localPointOnObject = attachedObject.transform.InverseTransformPoint(worldPosition);
                localForwardOnObject = attachedObject.transform.InverseTransformDirection(currentDirection);
                attachedRigidbody = attachedObject.GetComponent<Rigidbody>();
                if (attachedRigidbody)
                {
                    attachedRigidbody.velocity = Vector3.zero;
                }
                if (isCreature)
                {
                    localPointOnObject = Vector3.zero;
                }
                if (attachedRigidbody == null || attachedRigidbody.isKinematic || attachedRigidbody.mass >= 2000f)
                {
                    tooHeavyToPull = true;
                }
            }

            public bool TryGetAttachedPosition(out Vector3 position)
            {
                if (type == AttachmentType.Terrain)
                {
                    position = terrainPoint;
                    return true;
                }
                if (type == AttachmentType.Object || type == AttachmentType.Creature)
                {
                    if (attachedObject == null)
                    {
                        position = default;
                        return false;
                    }
                    position = attachedObject.transform.TransformPoint(localPointOnObject);
                    return true;
                }
                position = default;
                return false;
            }

            public bool TryGetAttachedDirection(out Vector3 forward)
            {
                /*if (type == AttachmentType.Terrain)
                {
                    forward = terrainAttachDirection;
                    return true;
                }
                if (type == AttachmentType.Object || type == AttachmentType.Creature)
                {
                    if (attachedObject == null)
                    {
                        forward = Vector3.down;
                        return false;
                    }
                    forward = attachedObject.transform.TransformDirection(localForwardOnObject);
                    return true;
                }*/
                forward = Vector3.down;
                return false;
            }

            public bool IsValid
            {
                get
                {
                    if (type == AttachmentType.Object || type == AttachmentType.Creature)
                    {
                        if (attachedObject == null)
                        {
                            return false;
                        }
                    }
                    return type != AttachmentType.None;
                }
            }
        }

        public enum AttachmentType
        {
            None,
            Terrain,
            Object,
            Creature
        }
    }
}
