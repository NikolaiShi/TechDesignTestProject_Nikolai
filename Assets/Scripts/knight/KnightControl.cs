using UnityEngine;
using System.Collections;
using Spine;
using Spine.Unity;

public class KnightControl : MonoBehaviour
{
    #region Inspector
    // [SpineAnimation] attribute allows an Inspector dropdown of Spine animation names coming form SkeletonAnimation.
    [SpineAnimation]
    public string runAnimationName;

    [SpineAnimation]
    public string idleAnimationName;

    [SpineAnimation]
    public string walkAnimationName;

    [SpineAnimation]
    public string atkAnimationName_1;

    [SpineAnimation]
    public string atkAnimationName_2;

    [SpineAnimation]
    public string jumpAnimationName;

    [SpineAnimation]
    public string hitAnimationName;

    [SpineAnimation]
    public string deathAnimationName;

    [SpineAnimation]
    public string stunAnimationName;

    [SpineAnimation]
    public string skillAnimationName_1;
    [SpineAnimation]
    public string skillAnimationName_2;
    [SpineAnimation]
    public string skillAnimationName_3;

    #endregion

    SkeletonAnimation skeletonAnimation;

    public Spine.AnimationState spineAnimationState;
    public Spine.Skeleton skeleton;

    public KeyCode attackKey = KeyCode.Mouse0;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode leftKey = KeyCode.A;

    public float moveSpeed = 3;
    void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();
        spineAnimationState = skeletonAnimation.AnimationState;
        skeleton = skeletonAnimation.Skeleton;
    }

    public void running()
    {
        spineAnimationState.SetAnimation(0, runAnimationName, true);
    }
    public void walking()
    {
        spineAnimationState.SetAnimation(0, walkAnimationName, true);
    }
    public void idle()
    {
        spineAnimationState.SetAnimation(0, idleAnimationName, true);
    }
    public void jump()
    {
        spineAnimationState.SetAnimation(0, jumpAnimationName, true);
    }
    public void getHit()
    {
        spineAnimationState.SetAnimation(0, hitAnimationName, true);
    }
    public void death()
    {
        spineAnimationState.SetAnimation(0, deathAnimationName, true);
    }
    public void stun()
    {
        spineAnimationState.SetAnimation(0, stunAnimationName, true);
    }
    public void attack_1()
    {
        spineAnimationState.SetAnimation(0, atkAnimationName_1, true);
    }
    public void attack_2()
    {
        spineAnimationState.SetAnimation(0, atkAnimationName_2, true);
    }
    public void skill_1()
    {
        spineAnimationState.SetAnimation(0, skillAnimationName_1, true);
    }
    public void skill_2()
    {
        spineAnimationState.SetAnimation(0, skillAnimationName_2, true);
    }
    public void skill_3()
    {
        spineAnimationState.SetAnimation(0, skillAnimationName_3, true);
    }

    void Update()
    {
        if (Input.GetKey(attackKey))
        {
            skeletonAnimation.AnimationName = atkAnimationName_2;
        }
        else
        {
            float newX = transform.position.x;

            if (Input.GetKey(rightKey))
            {
                newX += moveSpeed * Time.deltaTime;
                skeletonAnimation.AnimationName = walkAnimationName;
                skeletonAnimation.Skeleton.ScaleX = 1;
            }
            else if (Input.GetKey(leftKey))
            {
                newX -= moveSpeed * Time.deltaTime;
                skeletonAnimation.AnimationName = walkAnimationName;
                skeletonAnimation.Skeleton.ScaleX = -1;
            }
            else
            {
                skeletonAnimation.AnimationName = idleAnimationName;
            }

            newX = Mathf.Clamp(newX, -6.5f, 6.5f);

            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
    }


}
