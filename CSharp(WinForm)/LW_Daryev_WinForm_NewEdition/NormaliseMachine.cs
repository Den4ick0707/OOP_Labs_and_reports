using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_Daryev_WinForm_NewEdition.Nomalisation
{
    public static class NormaliseMashine
    {
        /// <summary>
        /// Function to denormalise a point from [0, 1] range to actual pixel coordinates based on the form's client size.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Point DenormalisePoint(Form form, float x, float y)
        {
            if (form == null)
                throw new ArgumentNullException(nameof(form));

            if (x < 0 || x > 1 || y < 0 || y > 1)
                throw new ArgumentOutOfRangeException(nameof(x), "x and y must be in the range [0, 1]");


            int denormX = (int)(x * form.ClientSize.Width);
            int denormY = (int)(y * form.ClientSize.Height);

            return new Point(denormX, denormY);
        }
        public static Point DenormalisePoint(Form form, PointF pointF)
        {
            if (form == null)
                throw new ArgumentNullException(nameof(form));

            if (pointF.X < 0 || pointF.X > 1 || pointF.Y < 0 || pointF.Y > 1)
                throw new ArgumentOutOfRangeException(nameof(pointF), "x and y must be in the range [0, 1]");

            int denormX = (int)(pointF.X * form.ClientSize.Width);
            int denormY = (int)(pointF.Y * form.ClientSize.Height);

            return new Point(denormX, denormY);
        }
        public static Size DenormaliseSize(Form form, float width, float height)
        {
            if (form == null)
                throw new ArgumentNullException(nameof(form));

            if (width < 0 || width > 1 || height < 0 || height > 1)
                throw new ArgumentOutOfRangeException(nameof(width), "width and height must be in the range [0, 1]");

            int denormWidth = (int)(width * form.ClientSize.Width);
            int denormHeight = (int)(height * form.ClientSize.Height);
            return new Size(denormWidth, denormHeight);
        }
        public static Size DenormaliseSize(Form form, SizeF sizeF)
        {
            if (form == null)
                throw new ArgumentNullException(nameof(form));
            if (sizeF.Width < 0 || sizeF.Width > 1 || sizeF.Height < 0 || sizeF.Height > 1)
                throw new ArgumentOutOfRangeException(nameof(sizeF), "width and height must be in the range [0, 1]");
            int denormWidth = (int)(sizeF.Width * form.ClientSize.Width);
            int denormHeight = (int)(sizeF.Height * form.ClientSize.Height);
            return new Size(denormWidth, denormHeight);
        }
    }
}
