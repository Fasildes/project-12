using System;
using Avalonia.Animation.Animators;
using Avalonia.Media;

namespace Avalonia.Animation
{
    /// <summary>
    /// Transition class that handles <see cref="AvaloniaProperty"/> with <see cref="BoxShadows"/> type.
    /// </summary>  
    public class BoxShadowsTransition : Transition<BoxShadows>
    {
        internal override IObservable<BoxShadows> DoTransition(IObservable<double> progress, BoxShadows oldValue,
            BoxShadows newValue) =>
            AnimatorDrivenTransition<BoxShadows, BoxShadowsAnimator>.Transition(Easing, progress, oldValue, newValue);
    }
}
