using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ContainerControl.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableContainerControlEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoValidateChanged event on the ContainerControl instance.
    /// </summary>
    /// <param name="instance">The ContainerControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoValidateChanged event on the ContainerControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoValidateChangedObservable(this ContainerControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoValidateChanged += handler,
            handler => instance.AutoValidateChanged -= handler);
    }
}
