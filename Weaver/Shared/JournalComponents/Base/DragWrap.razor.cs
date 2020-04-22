using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Weaver.Data.Models;

namespace Weaver.Shared.JournalComponents.Base
{
    public partial class DragWrap
    {
        [Parameter] public Draggable<JournalComponent> Child { get; set; }

        // when a draggable element enters this drop target
        public void OnDragEnter(DragEventArgs args)
        {
            Child.OnDragEnter(args);
        }
        // when a draggable element leaves this drop target
        public void OnDragLeave(DragEventArgs args)
        {
            Child.OnDragLeave(args);
        }
        // while a draggable element is being dragged over this drop target
        public void OnDragOver(DragEventArgs args)
        {
            Child.OnDragOver(args);
        }
        // when drag starts
        public void OnDragStart(DragEventArgs args)
        {
            Child.OnDragStart(args);
        }
        // when drag stops
        public void OnDragEnd(DragEventArgs args)
        {
            Child.OnDragEnd(args);
        }
        // while dragging
        public void OnDrag(DragEventArgs args)
        {
            Child.OnDrag(args);
        }
    }
}
