using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using Weaver.Data.Models;

namespace Weaver.Shared.JournalComponents.Base
{
    public interface IDraggable
    {
        public abstract void OnDragEnter(DragEventArgs args);
        // when a draggable element leaves this drop target
        public abstract void OnDragLeave(DragEventArgs args);
        // while a draggable element is being dragged over this drop target
        public abstract void OnDragOver(DragEventArgs args);
        // when drag starts
        public abstract void OnDragStart(DragEventArgs args);
        // when drag stops
        public abstract void OnDragEnd(DragEventArgs args);
        // while dragging
        public abstract void OnDrag(DragEventArgs args);
    }

    public class Draggable<T> : ComponentBase, IDraggable where T : JournalComponent
    {
        [Parameter] public T Component { get; set; }
        [Parameter] public EventCallback<T> ComponentChanged { get; set; }
        [Parameter] public bool Edit { get; set; } = false;
        [Inject] protected IJSRuntime JSRuntime { get; set; }

        // when a draggable element enters this drop target
        public virtual void OnDragEnter(DragEventArgs args)
        {
            JSRuntime.InvokeVoidAsync("console.log", "drag enter: ", Component.Label);
        }
        // when a draggable element leaves this drop target
        public virtual void OnDragLeave(DragEventArgs args)
        {
            JSRuntime.InvokeVoidAsync("console.log", "drag leave: ", Component.Label);
        }
        // while a draggable element is being dragged over this drop target
        public virtual void OnDragOver(DragEventArgs args)
        {
            JSRuntime.InvokeVoidAsync("console.log", "drag over: ", Component.Label);
        }
        // when drag starts
        public virtual void OnDragStart(DragEventArgs args)
        {
            JSRuntime.InvokeVoidAsync("console.log", "drag start: ", Component.Label);
        }
        // when drag stops
        public virtual void OnDragEnd(DragEventArgs args)
        {
            JSRuntime.InvokeVoidAsync("console.log", "drag end: ", Component.Label);
        }
        // while dragging
        public virtual void OnDrag(DragEventArgs args)
        {
            JSRuntime.InvokeVoidAsync("console.log", "drag: ", Component.Label);
        }
    }
}
