namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolTip.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolTipEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the Draw event on the ToolTip instance.
    /// </summary>
    /// <param name="instance">The ToolTip instance to observe.</param>
    /// <returns>An observable sequence wrapping the Draw event on the ToolTip instance.</returns>
    public static IObservable<EventPattern<DrawToolTipEventArgs>> DrawObservable(this ToolTip instance)
    {
        return Observable.FromEventPattern<DrawToolTipEventHandler, DrawToolTipEventArgs>(
            handler => instance.Draw += handler,
            handler => instance.Draw -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Popup event on the ToolTip instance.
    /// </summary>
    /// <param name="instance">The ToolTip instance to observe.</param>
    /// <returns>An observable sequence wrapping the Popup event on the ToolTip instance.</returns>
    public static IObservable<EventPattern<PopupEventArgs>> PopupObservable(this ToolTip instance)
    {
        return Observable.FromEventPattern<PopupEventHandler, PopupEventArgs>(
            handler => instance.Popup += handler,
            handler => instance.Popup -= handler);
    }
}
