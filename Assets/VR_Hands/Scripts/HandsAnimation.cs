using UnityEngine;
using UnityEngine.InputSystem;

public class HandsAnimation : MonoBehaviour {
    [SerializeField] private InputActionReference gripActionRef;
    [SerializeField] private InputActionReference triggerActionRef;
    [SerializeField] private Animator handAnimator;
    
    private readonly int _gripHashVal = Animator.StringToHash("Grip");
    private readonly int _triggerHashVal = Animator.StringToHash("Trigger");
    
    private float _gripVal, _triggerVal;
    
    // Update is called once per frame
    private void Update() {
        _gripVal = gripActionRef.action.ReadValue<float>();
        _triggerVal = triggerActionRef.action.ReadValue<float>();
        
        handAnimator.SetFloat(_gripHashVal, _gripVal);
        handAnimator.SetFloat(_triggerHashVal, _triggerVal);
    }
}
