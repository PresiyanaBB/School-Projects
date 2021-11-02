using System;
using System.Collections.Generic;
using System.Text;

namespace farm
{
    abstract class Food
    {
        protected int quantity;
        public virtual void Veggie()
        {
            quantity = 0;
        }
        public virtual void Meatt()
        {
            quantity = 0;
        }
    }
}
