using System.Windows.Forms.Design;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ComponentEditorForm.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableComponentEditorFormEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the ComponentEditorForm instance.
    /// </summary>
    /// <param name="instance">The ComponentEditorForm instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ComponentEditorForm instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ComponentEditorForm instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }
}
