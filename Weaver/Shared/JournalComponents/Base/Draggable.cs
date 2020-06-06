using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using Weaver.Data.Models;

namespace Weaver.Shared.JournalComponents.Base
{
    public class Draggable<T> : ComponentBase where T : JournalComponent
    {
        [Parameter] public T Component { get; set; }
        [Parameter] public EventCallback<T> ComponentChanged { get; set; }
        [Parameter] public bool Edit { get; set; } = false;

        // when a draggable element enters this drop target
        public virtual void OnDragEnter(DragEventArgs args)
        {
        }
        // when a draggable element leaves this drop target
        public virtual void OnDragLeave(DragEventArgs args)
        {

        }
        // while a draggable element is being dragged over this drop target
        public virtual void OnDragOver(DragEventArgs args)
        {

        }
        // when drag starts
        public virtual void OnDragStart(DragEventArgs args)
        {

        }
        // when drag stops
        public virtual void OnDragEnd(DragEventArgs args)
        {

        }
        // while dragging
        public virtual void OnDrag(DragEventArgs args)
        {

        }
    }
}
