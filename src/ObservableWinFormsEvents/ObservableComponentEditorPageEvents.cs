using System.Windows.Forms.Design;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ComponentEditorPage.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableComponentEditorPageEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the ComponentEditorPage instance.
    /// </summary>
    /// <param name="instance">The ComponentEditorPage instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ComponentEditorPage instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ComponentEditorPage instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }
}
