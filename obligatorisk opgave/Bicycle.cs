using System;
using System.Collections.Generic;
using System.Text;

namespace obligatorisk_opgave
{
    public class Bicycle
    {
		private int _id;

		public int Id	
		{
			get { return _id; }
			set { _id = value; }
		}


		private string _colour;

		public string Colour
		{
			get { return _colour; }
            set
            {
                if (value.Length <= 0)
                    throw new ArgumentOutOfRangeException();
                _colour = value;
                
            }
        }


		private int _price;

		public int Price
		{
			get { return _price; }
            set
            {
				if(value <= 0)
					throw new ArgumentOutOfRangeException();
                _price = value;
            }
		}



		private int _gear;

		public int Gear
		{
			get { return _gear; }
            set
            {
                if (value < 3 || value > 32)
					throw new ArgumentOutOfRangeException();
                _gear = value;
            }
		}


        public Bicycle(int id, string colour, int price, int gear)
        {
            Id = id;
            Colour = colour;
            Price = price;
            Gear = gear;
        }



	}
}
