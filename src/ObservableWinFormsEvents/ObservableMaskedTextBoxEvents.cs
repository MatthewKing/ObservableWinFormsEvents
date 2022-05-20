namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on MaskedTextBox.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableMaskedTextBoxEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AcceptsTabChanged event on the MaskedTextBox instance.
    /// </summary>
    /// <param name="instance">The MaskedTextBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the AcceptsTabChanged event on the MaskedTextBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AcceptsTabChangedObservable(this MaskedTextBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AcceptsTabChanged += handler,
            handler => instance.AcceptsTabChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the IsOverwriteModeChanged event on the MaskedTextBox instance.
    /// </summary>
    /// <param name="instance">The MaskedTextBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the IsOverwriteModeChanged event on the MaskedTextBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> IsOverwriteModeChangedObservable(this MaskedTextBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.IsOverwriteModeChanged += handler,
            handler => instance.IsOverwriteModeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MaskChanged event on the MaskedTextBox instance.
    /// </summary>
    /// <param name="instance">The MaskedTextBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the MaskChanged event on the MaskedTextBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MaskChangedObservable(this MaskedTextBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MaskChanged += handler,
            handler => instance.MaskChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MaskInputRejected event on the MaskedTextBox instance.
    /// </summary>
    /// <param name="instance">The MaskedTextBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the MaskInputRejected event on the MaskedTextBox instance.</returns>
    public static IObservable<EventPattern<MaskInputRejectedEventArgs>> MaskInputRejectedObservable(this MaskedTextBox instance)
    {
        return Observable.FromEventPattern<MaskInputRejectedEventHandler, MaskInputRejectedEventArgs>(
            handler => instance.MaskInputRejected += handler,
            handler => instance.MaskInputRejected -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MultilineChanged event on the MaskedTextBox instance.
    /// </summary>
    /// <param name="instance">The MaskedTextBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the MultilineChanged event on the MaskedTextBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MultilineChangedObservable(this MaskedTextBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MultilineChanged += handler,
            handler => instance.MultilineChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextAlignChanged event on the MaskedTextBox instance.
    /// </summary>
    /// <param name="instance">The MaskedTextBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextAlignChanged event on the MaskedTextBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextAlignChangedObservable(this MaskedTextBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextAlignChanged += handler,
            handler => instance.TextAlignChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TypeValidationCompleted event on the MaskedTextBox instance.
    /// </summary>
    /// <param name="instance">The MaskedTextBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the TypeValidationCompleted event on the MaskedTextBox instance.</returns>
    public static IObservable<EventPattern<TypeValidationEventArgs>> TypeValidationCompletedObservable(this MaskedTextBox instance)
    {
        return Observable.FromEventPattern<TypeValidationEventHandler, TypeValidationEventArgs>(
            handler => instance.TypeValidationCompleted += handler,
            handler => instance.TypeValidationCompleted -= handler);
    }
}
