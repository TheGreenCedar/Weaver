using Blazor.DragDrop.Core;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Weaver.Data.Models;

namespace Weaver.Shared.JournalComponents
{
    public partial class JGrid
    {
        [Parameter] public bool Building { get; set; } = false;
        [Inject] private DragDropService _dds { get; set; }
        private int _rows = 0;
        public int Rows
        {
            get { if (_rows == 0) { _rows = Component.Children.Count; } return _rows; }
            set => _rows = value;
        }

        private string IdFromRow(int row) => $"{row}_{DropzoneName}";
        private string DropzoneName { get => $"JGridDropzone_{Component.Position}"; }
        public static int RowFromId(string id)
        {
            if (id is null) throw new System.Exception("id is null");
            int row = int.Parse(id[..id.IndexOf('_', 0)]);
            return row;
        }

        private Task onchange<U, T>(U val, ref T item)
            where T : ValueComponent<U>
        {
            item.MappedValue = val;
            return ComponentChanged.InvokeAsync(Component);
        }

        private async void OnDrop(DraggableItem item)
        {
            if (item.OriginDropzoneId != item.DropzoneId) throw new System.Exception("Item dropped into wrong dropzone");
            var draggables = _dds.GetDraggablesForDropzone(DropzoneName);
            foreach (var draggable in draggables)
            {
                int idx = RowFromId(draggable.Name);
                await childrenRefs[idx].SetPosition(draggable?.OrderPosition ?? -1);
            }
        }
    }
}
