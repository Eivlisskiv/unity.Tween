using IgnitedBox.Tweening.Tweeners.VectorTweeners;
using UnityEngine;

namespace IgnitedBox.Tweening.TweenPresets
{
    public static class TransformPresets
    {
        public static ScaleTween TweenScale(this Transform transform,
            Vector3 targetScale, float time, float delay = 0, 
            System.Func<double, double> easing = null, System.Action callback = null)
            => transform.Tween<Transform, Vector3, ScaleTween>
            (targetScale, time, delay, easing, callback);

        public static LocalPositionTween TweenLocalPosition(this Transform transform,
            Vector3 targetPosition, float time, float delay = 0,
            System.Func<double, double> easing = null, System.Action callback = null)
            => transform.Tween<Transform, Vector3, LocalPositionTween>
            (targetPosition, time, delay, easing, callback);

        public static LocalPositionTween TweenPosition(this Transform transform,
            Vector3 targetPosition, float time, float delay = 0,
            System.Func<double, double> easing = null, System.Action callback = null)
            => transform.Tween<Transform, Vector3, LocalPositionTween>
            (targetPosition, time, delay, easing, callback);

        public static RectSizeTween TweenSize(this RectTransform transform,
            Vector3 targetPosition, float time, float delay = 0,
            System.Func<double, double> easing = null, System.Action callback = null)
            => transform.Tween<RectTransform, Vector3, RectSizeTween>
            (targetPosition, time, delay, easing, callback);
    }
}
