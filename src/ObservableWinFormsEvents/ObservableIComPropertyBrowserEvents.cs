using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on IComPropertyBrowser.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableIComPropertyBrowserEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the ComComponentNameChanged event on the IComPropertyBrowser instance.
    /// </summary>
    /// <param name="instance">The IComPropertyBrowser instance to observe.</param>
    /// <returns>An observable sequence wrapping the ComComponentNameChanged event on the IComPropertyBrowser instance.</returns>
    public static IObservable<EventPattern<ComponentRenameEventArgs>> ComComponentNameChangedObservable(this IComPropertyBrowser instance)
    {
        return Observable.FromEventPattern<ComponentRenameEventHandler, ComponentRenameEventArgs>(
            handler => instance.ComComponentNameChanged += handler,
            handler => instance.ComComponentNameChanged -= handler);
    }
}
