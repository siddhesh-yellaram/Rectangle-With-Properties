using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithProperties.Model
{
    class Rectangle
    {
        private int _height;
        private int _width;
        private BorderStyle _border = BorderStyle.SOLID;

        public Rectangle(int width, int height) : this(width,height,BorderStyle.SOLID)
        { }

        public Rectangle(int width, int height, BorderStyle border)
        {
            _width = width;
            _height = height;
            _border = border;
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                    _height = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                    _width = value;
            }
        }

        public BorderStyle Border{
            get
            {
                return _border;
            }
            set{
                _border = BorderStyle.SOLID;
            }
        }

        public int calculateArea()
        {
            return _width * _height;
        }
    }
}
