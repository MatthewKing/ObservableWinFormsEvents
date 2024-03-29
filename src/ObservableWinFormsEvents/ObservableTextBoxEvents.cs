namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on TextBox.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableTextBoxEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the TextAlignChanged event on the TextBox instance.
    /// </summary>
    /// <param name="instance">The TextBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextAlignChanged event on the TextBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextAlignChangedObservable(this TextBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextAlignChanged += handler,
            handler => instance.TextAlignChanged -= handler);
    }
}
