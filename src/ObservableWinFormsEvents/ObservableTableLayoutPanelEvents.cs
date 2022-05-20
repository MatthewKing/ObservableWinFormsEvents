using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on TableLayoutPanel.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableTableLayoutPanelEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the CellPaint event on the TableLayoutPanel instance.
    /// </summary>
    /// <param name="instance">The TableLayoutPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the CellPaint event on the TableLayoutPanel instance.</returns>
    public static IObservable<EventPattern<TableLayoutCellPaintEventArgs>> CellPaintObservable(this TableLayoutPanel instance)
    {
        return Observable.FromEventPattern<TableLayoutCellPaintEventHandler, TableLayoutCellPaintEventArgs>(
            handler => instance.CellPaint += handler,
            handler => instance.CellPaint -= handler);
    }
}
