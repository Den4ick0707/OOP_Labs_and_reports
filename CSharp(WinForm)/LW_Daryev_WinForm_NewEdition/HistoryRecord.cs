using LW_Daryev_WinForm_NewEdition.Brush;
using LW_Daryev_WinForm_NewEdition.Shape;

namespace LW_Daryev_WinForm_NewEdition.HisotyManagment
{
    public class HistoryRecord
    {
        public List<IShapeDraw> ShapesSnapshot { get; }
        public List<IBrushDraw> BrushSnapshot { get; }

        public HistoryRecord(List<IShapeDraw> shapes, List<IBrushDraw> brushes)
        {
            ShapesSnapshot = new List<IShapeDraw>(shapes);
            BrushSnapshot = new List<IBrushDraw>(brushes);
        }
    }
}
