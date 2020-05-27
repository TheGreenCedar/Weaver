using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Weaver.Data.Models;

namespace Weaver.Shared.JournalComponents.Base
{
    public class Draggable<T> : ComponentBase where T : JournalComponent
    {
        [Parameter] public T Component { get; set; }
        [Parameter] public EventCallback<T> ComponentChanged { get; set; }

        // when a draggable element enters this drop target
        public void OnDragEnter(DragEventArgs args)
        {

        }
        // when a draggable element leaves this drop target
        public void OnDragLeave(DragEventArgs args)
        {

        }
        // while a draggable element is being dragged over this drop target
        public void OnDragOver(DragEventArgs args)
        {

        }
        // when drag starts
        public void OnDragStart(DragEventArgs args)
        {

        }
        // when drag stops
        public void OnDragEnd(DragEventArgs args)
        {

        }
        // while dragging
        public void OnDrag(DragEventArgs args)
        {

        }
    }
}
