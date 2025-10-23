using LW_Daryev_WinForm_NewEdition.Brush;
using LW_Daryev_WinForm_NewEdition.Shape;
using System.Collections.Generic;

namespace LW_Daryev_WinForm_NewEdition.HisotyManagment
{
    public class HistoryManager
    {
        private readonly Stack<HistoryRecord> undoStack = new();
        private readonly Stack<HistoryRecord> redoStack = new();
        public void SaveState(List<IShapeDraw> shapes, List<IBrushDraw> brushes)
        {
            undoStack.Push(new HistoryRecord(shapes, brushes));
            redoStack.Clear();
        }
        public HistoryRecord Undo()
        {
            if (undoStack.Count <= 1)
                return null;

            var current = undoStack.Pop();
            redoStack.Push(current);

            return undoStack.Peek();
        }
        public HistoryRecord Redo()
        {
            if (redoStack.Count == 0)
                return null;

            var state = redoStack.Pop();
            undoStack.Push(state);

            return state;
        }
    }
}
