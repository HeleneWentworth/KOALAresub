using System.Collections.Generic;

namespace KOALA.Interfaces
{
    public interface IDragAndDropHoverableView
    {
        void OnHovered(List<IDragAndDropMovingView> views);
    }
}