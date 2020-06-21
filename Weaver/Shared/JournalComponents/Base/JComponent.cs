using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Weaver.Data.Models;

namespace Weaver.Shared.JournalComponents.Base
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1040:Avoid empty interfaces", Justification = "<Pending>")]
    public interface IJComponent {
        public abstract Task SetPosition(int pos);
    }

    public class JComponent<T> : ComponentBase, IJComponent where T : JournalComponent
    {
        [Parameter] public T Component { get; set; }
        [Parameter] public EventCallback<T> ComponentChanged { get; set; }
        [Parameter] public bool Edit { get; set; } = false;

        public Task SetPosition(int pos)
        {
            Component.Position = pos;
            return ComponentChanged.InvokeAsync(Component);
        }
    }
}
