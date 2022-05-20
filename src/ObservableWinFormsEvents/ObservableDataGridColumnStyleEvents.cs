using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

#if NETFRAMEWORK

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on DataGridColumnStyle.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableDataGridColumnStyleEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AlignmentChanged event on the DataGridColumnStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridColumnStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the AlignmentChanged event on the DataGridColumnStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AlignmentChangedObservable(this DataGridColumnStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AlignmentChanged += handler,
            handler => instance.AlignmentChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PropertyDescriptorChanged event on the DataGridColumnStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridColumnStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the PropertyDescriptorChanged event on the DataGridColumnStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PropertyDescriptorChangedObservable(this DataGridColumnStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PropertyDescriptorChanged += handler,
            handler => instance.PropertyDescriptorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FontChanged event on the DataGridColumnStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridColumnStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the FontChanged event on the DataGridColumnStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this DataGridColumnStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FontChanged += handler,
            handler => instance.FontChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the HeaderTextChanged event on the DataGridColumnStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridColumnStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the HeaderTextChanged event on the DataGridColumnStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> HeaderTextChangedObservable(this DataGridColumnStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.HeaderTextChanged += handler,
            handler => instance.HeaderTextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MappingNameChanged event on the DataGridColumnStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridColumnStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the MappingNameChanged event on the DataGridColumnStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MappingNameChangedObservable(this DataGridColumnStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MappingNameChanged += handler,
            handler => instance.MappingNameChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the NullTextChanged event on the DataGridColumnStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridColumnStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the NullTextChanged event on the DataGridColumnStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> NullTextChangedObservable(this DataGridColumnStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.NullTextChanged += handler,
            handler => instance.NullTextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ReadOnlyChanged event on the DataGridColumnStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridColumnStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the ReadOnlyChanged event on the DataGridColumnStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ReadOnlyChangedObservable(this DataGridColumnStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ReadOnlyChanged += handler,
            handler => instance.ReadOnlyChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the WidthChanged event on the DataGridColumnStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridColumnStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the WidthChanged event on the DataGridColumnStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> WidthChangedObservable(this DataGridColumnStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.WidthChanged += handler,
            handler => instance.WidthChanged -= handler);
    }
}

#endif
