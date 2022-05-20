using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on BindingNavigator.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableBindingNavigatorEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the RefreshItems event on the BindingNavigator instance.
    /// </summary>
    /// <param name="instance">The BindingNavigator instance to observe.</param>
    /// <returns>An observable sequence wrapping the RefreshItems event on the BindingNavigator instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RefreshItemsObservable(this BindingNavigator instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RefreshItems += handler,
            handler => instance.RefreshItems -= handler);
    }
}
